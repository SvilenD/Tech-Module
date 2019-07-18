using BandRegister.Data;
using BandRegister.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BandRegister.Controllers
{
    public class BandController : Controller
    {

        public IActionResult Index()
        {
            using (var data = new BandRegisterDbContext())
            {
                var bands = data.Bands.ToList();

                return View(bands);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Band band)
        {
            using (var data = new BandRegisterDbContext())
            {
                if (ModelState.IsValid)
                {
                    data.Bands.Add(band);
                    data.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(band);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var data = new BandRegisterDbContext())
            {
                var band = data.Bands.Find(id);
                return View(band);
            }
        }

        [HttpPost]
        public IActionResult Edit(Band band)
        {
            using (var data = new BandRegisterDbContext())
            {
                data.Bands.Update(band);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var data = new BandRegisterDbContext())
            {
                var band = data.Bands.Find(id);
                return View(band);
            }
        }

        [HttpPost]
        public IActionResult Delete(Band band)
        {
            using (var data = new BandRegisterDbContext())
            {
                data.Bands.Remove(band);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}