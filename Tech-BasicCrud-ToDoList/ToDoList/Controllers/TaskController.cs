using Microsoft.AspNetCore.Mvc;
using System.Linq;
using ToDoList.Data;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var data = new ToDoDbContext())
            {
                var tasks = data.Tasks.ToList();
                return View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string title, string comments)
        {
            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(comments))
            {
                return RedirectToAction("Index");
            }

            Task task = new Task
            {
                Title = title,
                Comments = comments
            };

            using (var data = new ToDoDbContext())
            {
                data.Tasks.Add(task);
                data.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var data = new ToDoDbContext())
            {
                var task = data.Tasks.Find(id);
                if (task == null)
                {
                    return RedirectToAction("Index");
                }
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            using (var data = new ToDoDbContext())
            {
                data.Tasks.Update(task);
                data.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details (int id)
        {
            using (var data = new ToDoDbContext())
            {
                var task = data.Tasks.Find(id);
                if (task == null)
                {
                    return RedirectToAction("Index");
                }
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Delete(Task task)
        {
            using (var data = new ToDoDbContext())
            {
                data.Tasks.Remove(task);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}