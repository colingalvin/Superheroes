using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MySuperheroes.Data;
using MySuperheroes.Models;

namespace MySuperheroes.Controllers
{
    public class SuperheroesController : Controller
    {
        private readonly ApplicationDbContext _db; // create instance of communicator
        public SuperheroesController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: SuperheroesController
        public ActionResult Index()
        {
            var supers = _db.Superheroes.Select(s => s).ToList();
            return View(supers);
        }

        // GET: SuperheroesController/Details/5
        public ActionResult Details(int id)
        {
            var selectedSuper = _db.Superheroes.FirstOrDefault(s => s.Id == id);
            return View(selectedSuper);
        }

        // GET: SuperheroesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SuperheroesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Superhero superhero)
        {
            try
            {
                _db.Superheroes.Add(superhero); // take instance from View, add to the superhero table in database
                _db.SaveChanges();

                // Same as:
                //Superhero superhero1 = new Superhero();
                //superhero1.SuperName = "Frozone";
                //...
                //_db.Superheroes.Add(superhero1);

                return RedirectToAction(nameof(Index)); // Action = Method
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SuperheroesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Superhero superhero)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperheroesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperheroesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Superhero superhero)
        {
            try
            {
                _db.Superheroes.Remove(superhero);
                _db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
