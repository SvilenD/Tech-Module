using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Forum.Controllers
{
    public class TopicController : Controller
    {
        private readonly ForumDbContext context;

        public TopicController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Include(t => t.Comments)
                .ThenInclude(c => c.Author)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //Get: Topic-Create
        [Authorize]
        public IActionResult Create()
        {
            List<string> categoryNames = context.Categories.Select(c => c.Name).ToList();

            ViewData["CategoryNames"] = categoryNames;

            return View();
        }

        // Post:Topic-Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                //insert topic in DB
                topic.CreatedDate = DateTime.Now; // set CreatedDate
                topic.LastUpdatedDate = DateTime.Now; // set LastUpdatedDate

                string authorId = context.Users //get User id
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .First()
                    .Id;

                topic.AuthorId = authorId; // set topic author Id

                if (!context.Categories.Any(c => c.Name == categoryName))
                {
                    return View(topic);
                }

                int categoryId = context.Categories.SingleOrDefault(c => c.Name == categoryName).Id;

                topic.CategoryId = categoryId;

                context.Topics.Add(topic); //save topic
                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(topic);
        }

        //GET: Topic-Delete/id
        [Authorize]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Topic topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return View(topic);
        }

        //POST Topic-Delete/id
        [HttpPost]
        [Authorize]
        public IActionResult Delete(int id)
        {
            //get topic
            Topic topic = context.Topics
                .Include(t => t.Author)
                .SingleOrDefault(m => m.Id == id);

            //check if topic exists
            if (topic != null)
            {
                //delete topic 
                context.Remove(topic);
                context.SaveChanges();
            }
            //redirect to Index
            return RedirectToAction("Index", "Home");
        }

        //Get Topic Edit/id
        [HttpGet]
        [Authorize]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            //get topic fm Database
            Topic topic = context.Topics
                .Include(t => t.Author)
                .Include(t => t.Category)
                .Where(t => t.Id == id)
                .SingleOrDefault();

            //check if topic exists
            if (topic == null)
            {
                return RedirectToAction("Index", "Home");
            }

            //if (!IsUserAuthorizedToEdit(topic))
            if (!topic.IsAuthor(User.Identity.Name))
            {
                return Forbid();
            }

            List<string> categoryNames = context.Categories.Select(c => c.Name).ToList();

            ViewData["CategoryNames"] = categoryNames;
            // pass the model to View
            return View(topic);
        }

        //Post Edit Topic/id
        [HttpPost]
        [Authorize]
        public IActionResult Edit(string categoryName, Topic topic)
        {
            if (ModelState.IsValid)
            {
                //get topic from Database
                Topic topicFromDb = context.Topics
                    .Include(t => t.Author)
                    .SingleOrDefault(t => t.Id.Equals(topic.Id));

                //check if topic exists
                if (topicFromDb == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                // set new properties
                topicFromDb.Title = topic.Title;
                topicFromDb.Description = topic.Description;

                int categoryId = context.Categories.SingleOrDefault(c => c.Name == categoryName).Id;
                topicFromDb.CategoryId = categoryId;

                topicFromDb.LastUpdatedDate = DateTime.Now;
                context.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            return View(topic);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}