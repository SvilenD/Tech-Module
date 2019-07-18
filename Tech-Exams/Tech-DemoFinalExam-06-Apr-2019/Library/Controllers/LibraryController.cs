using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            using (var data = new LibraryDbContext())
            {
                List<Book> books = data.Books.ToList();
                return View(books);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                using (var data = new LibraryDbContext())
                {
                    data.Books.Add(book);
                    data.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var data = new LibraryDbContext())
            {
                var bookToEdit = data.Books.FirstOrDefault(b=>b.Id == id);
                if (bookToEdit == null)
                {
                    RedirectToAction("Index");
                }
                return View(bookToEdit);
            }
        }

        [HttpPost]
        public IActionResult Edit(Book bookToEdit)
        {
            if (!ModelState.IsValid)
            {
                RedirectToAction("Index");
            }

            using (var data = new LibraryDbContext())
            {
                data.Update(bookToEdit);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var data = new LibraryDbContext())
            {
                var bookToDelete = data.Books.FirstOrDefault(b => b.Id == id);
                if (bookToDelete == null)
                {
                    RedirectToAction("Index");
                }
                return View(bookToDelete);
            }
        }

        [HttpPost]
        public IActionResult Delete(Book bookToDelete)
        {
            using (var data = new LibraryDbContext())
            {
                data.Books.Remove(bookToDelete);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}