using Forum.Data;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Forum.Controllers
{
    public class HomeController : Controller
    {
        private readonly ForumDbContext context;

        public HomeController(ForumDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = context.Categories
                .Include(c => c.Author)
                .Include(c => c.Topics)
                .ThenInclude(t => t.Author)
                .ToList();

            List<Topic> topics = context
                .Topics
                .Include(t => t.Comments)
                .Include(c => c.Author)
                .OrderByDescending(t => t.CreatedDate)
                .ThenByDescending(t => t.LastUpdatedDate)
                .ToList();

            ViewData["Categories"] = categories;

            return View(topics);
        }
    }
}