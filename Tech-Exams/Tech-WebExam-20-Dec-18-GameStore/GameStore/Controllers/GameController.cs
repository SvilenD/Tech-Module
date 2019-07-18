namespace GameStore.Controllers
{
    using GameStore.Data;
    using GameStore.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    public class GameController : Controller
    {
        public IActionResult Index()
        {
            using (GameStoreDbContext data = new GameStoreDbContext())
            {
                List<Game> games = data.Games.ToList();

                return View(games);
            }
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string dlc, decimal price, string platform)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(dlc) || string.IsNullOrEmpty(platform))
            {
                return RedirectToAction("Index");
            }

            Game game = new Game
            {
                Name = name,
                Dlc = dlc,
                Price = price,
                Platform = platform
            };

            using (var data = new GameStoreDbContext())
            {
                data.Games.Add(game);
                data.SaveChanges();
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            using (var data = new GameStoreDbContext())
            {
                Game game = data.Games.Find(id);
                if (game == null)
                {
                    return RedirectToAction("Index");
                }
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Edit(Game game)
        {
            using (var data = new GameStoreDbContext())
            {
                data.Games.Update(game);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            using (var data = new GameStoreDbContext())
            {
                var game = data.Games.Find(id);
                if (game == null)
                {
                    return RedirectToAction("Index");
                }
                return View(game);
            }
        }

        [HttpPost]
        public IActionResult Delete(Game game)
        {
            using (var data = new GameStoreDbContext())
            {
                data.Remove(game);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}