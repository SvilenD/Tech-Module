using Microsoft.AspNetCore.Mvc;
using SoftuniTwitter.Data;
using SoftuniTwitter.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace SoftuniTwitter.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext data;

        public HomeController(ApplicationDbContext db)
        {
            this.data = db;
        }

        public IActionResult Index()
        {
            var model = data.Tweets.Select(t => new TweetViewModel
            {
                Text = t.Text,
                CreatedOn = t.CreatedOn,
                Username = t.User.UserName
            })
            .OrderByDescending(t => t.CreatedOn)
            .ToList();

            foreach (var tweet in model)
            {
                tweet.Text = Regex.Replace(tweet.Text, @"#(?<name>[\w]+)", @"<a href='/Tweets/ByHashTag/${name}'>$0</a>"); 
            }

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
