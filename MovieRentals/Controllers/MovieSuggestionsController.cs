using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MovieRentals.Models;

namespace MovieRentals.Controllers
{
    public class MovieSuggestionsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: MovieSuggestions
        public ActionResult Index()
        {
            return View(db.Suggestions.ToList());
        }

        // GET: MovieSuggestions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieSuggestion movieSuggestion = db.Suggestions.Find(id);
            if (movieSuggestion == null)
            {
                return HttpNotFound();
            }
            return View(movieSuggestion);
        }

        // GET: MovieSuggestions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MovieSuggestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FullName,Suggestion")] MovieSuggestion movieSuggestion)
        {
            if (ModelState.IsValid)
            {
                db.Suggestions.Add(movieSuggestion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movieSuggestion);
        }

        // GET: MovieSuggestions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieSuggestion movieSuggestion = db.Suggestions.Find(id);
            if (movieSuggestion == null)
            {
                return HttpNotFound();
            }
            return View(movieSuggestion);
        }

        // POST: MovieSuggestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FullName,Suggestion")] MovieSuggestion movieSuggestion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movieSuggestion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movieSuggestion);
        }

        // GET: MovieSuggestions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MovieSuggestion movieSuggestion = db.Suggestions.Find(id);
            if (movieSuggestion == null)
            {
                return HttpNotFound();
            }
            return View(movieSuggestion);
        }

        // POST: MovieSuggestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MovieSuggestion movieSuggestion = db.Suggestions.Find(id);
            db.Suggestions.Remove(movieSuggestion);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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
