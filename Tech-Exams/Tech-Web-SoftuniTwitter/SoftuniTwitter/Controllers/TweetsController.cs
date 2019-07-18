using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SoftuniTwitter.Data;
using SoftuniTwitter.Models;

namespace SoftuniTwitter.Controllers
{
    [Authorize]
    public class TweetsController : Controller
    {
        ApplicationDbContext db;

        public TweetsController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string text)
        {
            var tweet = new Tweet();
            tweet.Text = text;
            tweet.CreatedOn = DateTime.Now;
            if (this.User == null)
            {
                return View();
            }
            tweet.UserId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            db.Tweets.Add(tweet);
            db.SaveChanges();

            return Redirect("/");
        }

        public IActionResult ByHashTag(string id)
        {
            var model = db.Tweets.Select(t =>
            new TweetViewModel
            {
                CreatedOn = t.CreatedOn,
                Text = t.Text,
                Username = t.User.UserName
            }).OrderByDescending(t => t.CreatedOn)
            .Where(t => t.Text.Contains("#" + id))
            .ToList();

            return View(model);
        }

        public IActionResult Search(string hashtag)
        {
            var model = db.Tweets.Select(t =>
            new TweetViewModel
            {
                CreatedOn = t.CreatedOn,
                Text = t.Text,
                Username = t.User.UserName
            }).OrderByDescending(t => t.CreatedOn)
            .Where(t => t.Text.Contains("#" + hashtag))
            .ToList();

            return View(model);
        }

    }
}