using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyWebsite.Models;
using Microsoft.AspNet.Identity;

namespace MyWebsite.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Movies
        public ActionResult Index(string searchString, string MovieGenre)
        {
            var movieQuery = from m in db.Movies select m;

            var movieGenre = from m in db.Movies orderby m.Genre select m.Genre;

            ViewBag.MovieGenre = new SelectList(movieGenre.Distinct());

            if (!String.IsNullOrEmpty(searchString))
            {
                movieQuery = movieQuery.Where(m => m.Title.Contains(searchString));
            }

            if (!String.IsNullOrEmpty(MovieGenre)) {
                movieQuery = movieQuery.Where(m => m.Genre.Equals(MovieGenre));
            }
            
            return View(movieQuery);
        }

        // GET: Movies/Details/5
        public ActionResult Details(Guid? id)
        {


            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieEntity movieEntity = db.Movies.Find(id);
            if (movieEntity == null)
            {
                return HttpNotFound();
            }
            return View(movieEntity);
        }

        // GET: Movies/Create
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Create([Bind(Include = "Id,Title,Genre,Image,ReleasedDate,Plot,Price")] MovieEntity movieEntity)
        {
            if (ModelState.IsValid)
            {
                movieEntity.Id = Guid.NewGuid();
                db.Movies.Add(movieEntity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieEntity);
        }

        // GET: Movies/Edit/5
        [Authorize]
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieEntity movieEntity = db.Movies.Find(id);
            if (movieEntity == null)
            {
                return HttpNotFound();
            }
            return View(movieEntity);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult Edit([Bind(Include = "Id,Title,Genre,Image,ReleasedDate,Plot,Price")] MovieEntity movieEntity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieEntity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieEntity);
        }

        // GET: Movies/Delete/5
        [Authorize]
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieEntity movieEntity = db.Movies.Find(id);
            if (movieEntity == null)
            {
                return HttpNotFound();
            }
            return View(movieEntity);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult DeleteConfirmed(Guid id)
        {
            MovieEntity movieEntity = db.Movies.Find(id);
            db.Movies.Remove(movieEntity);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [Authorize]
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
