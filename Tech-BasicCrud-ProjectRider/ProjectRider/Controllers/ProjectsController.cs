
namespace ProjectRider.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ProjectRider.Models;
    using System.Linq;

    public class ProjectController : Controller
    {
        [HttpGet]
        [Route("")]
        public ActionResult Index()
        {
            using (var db = new ProjectDbContext())
            {
                var projectsList = db.Projects.ToList();
                return View(projectsList);
            }
        }

        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("create")]
        public ActionResult Create(Project project)
        {
            using (var db = new ProjectDbContext())
            {
                if (ModelState.IsValid)
                {
                    db.Projects.Add(project);
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            using (var db = new ProjectDbContext())
            {
                var projectToEdit = db.Projects.Find(id);
                if (projectToEdit == null)
                {
                    return RedirectToAction("Index");
                }
                return View(projectToEdit);
            }
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(Project projectToEdit)
        {
            if (ModelState.IsValid == false)
            {
                return RedirectToAction("Index");
            }
            using (var db = new ProjectDbContext())
            {
                db.Projects.Update(projectToEdit);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            using (var db = new ProjectDbContext())
            {
                var projectToDelete = db.Projects.FirstOrDefault(p => p.Id == id);
                if (projectToDelete == null)
                {
                    return RedirectToAction("Index");
                }
                return View(projectToDelete);
            }
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(Project projectToDelete)
        {
            using (var db = new ProjectDbContext())
            {
                db.Projects.Remove(projectToDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
