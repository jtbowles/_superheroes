using SuperheroProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperheroProject.Controllers
{
    public class SuperheroController : Controller
    {
        ApplicationDbContext db;

        public SuperheroController()
        {
            db = new ApplicationDbContext();
        }

        // GET: Superhero
        public ActionResult Index()
        {
            var listOfSuperheroes = db.Superheroes.ToList();
            return View(listOfSuperheroes);
        }

        // GET: Superhero/Details/5
        public ActionResult Details(int id)
        {
            var superheroFromDb = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superheroFromDb);
        }

        // GET: Superhero/Create
        public ActionResult Create()
        {
            Superhero superhero = new Superhero();
            return View(superhero);
        }

        // POST: Superhero/Create
        [HttpPost]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                db.Superheroes.Add(superhero);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Edit/5
        public ActionResult Edit(int id)
        {
            var superToEdit = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superToEdit);
        }

        // POST: Superhero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add update logic here
                var superToEdit = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                superToEdit.SuperName = superhero.SuperName;
                superToEdit.AlterEgo = superhero.AlterEgo;
                superToEdit.PrimaryAbility = superhero.PrimaryAbility;
                superToEdit.SecondaryAbility = superhero.SecondaryAbility;
                superToEdit.CatchPhrase = superhero.CatchPhrase;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Superhero/Delete/5
        public ActionResult Delete(int id)
        {
            var superToDelete = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
            return View(superToDelete);
        }

        // POST: Superhero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                // TODO: Add delete logic here
                var superToDelete = db.Superheroes.Where(s => s.Id == id).FirstOrDefault();
                db.Superheroes.Remove(superToDelete);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
