﻿namespace TeisterMask.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    using TeisterMask.Data;
    using TeisterMask.Models;

    public class TaskController : Controller
    {
        public IActionResult Index()
        {
            using (var db = new MeisterTaskDbContext())
            {
                var tasks = db.Tasks.ToList();

                return View(tasks);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create (Task task)
        {
            using (var db = new MeisterTaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit (int id)
        {
            using (var db = new MeisterTaskDbContext())
            {
                Task task = db.Tasks.Find(id);
                return View(task);
            }
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            using (var db = new MeisterTaskDbContext())
            {
                db.Tasks.Update(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");

        }


        [HttpGet]
        public IActionResult Delete (int id)
        {
            using (var db = new MeisterTaskDbContext())
            {
                Task task = db.Tasks.Find(id);
                return View(task); 
            }
        }

        [HttpPost]
        public IActionResult Delete (Task task)
        {
            using (var db = new MeisterTaskDbContext())
            {
                db.Tasks.Remove(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}