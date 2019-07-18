using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using TeisterMask.Data;
using TeisterMask.Models;

namespace TeisterMask.Controllers
{
    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var data = new TeisterMaskDbContext())
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
        public IActionResult Create(Task task)
        {
            using (var data = new TeisterMaskDbContext())
            {
                data.Tasks.Add(task);
                task.Time = DateTime.Now.ToString("HH:mm dd/MM/yy");
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var data = new TeisterMaskDbContext())
            {
                var task = data.Tasks.FirstOrDefault(t => t.Id == id);
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
            using (var data = new TeisterMaskDbContext())
            {
                task.Time = DateTime.Now.ToString("HH:mm dd/MM/yy");
                data.Tasks.Update(task);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var data = new TeisterMaskDbContext())
            {
                Task task = data.Tasks.Find(id);

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
            using (var data = new TeisterMaskDbContext())
            {
                data.Remove(task);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}