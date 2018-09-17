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
    public class TransactionItemsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: TransactionItems
        public ActionResult Index()
        {
            return View(db.TransactionItems.ToList());
        }

        // GET: TransactionItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionItem transactionItem = db.TransactionItems.Find(id);
            if (transactionItem == null)
            {
                return HttpNotFound();
            }
            return View(transactionItem);
        }

        // GET: TransactionItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TransactionItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,TransactionId,MovieId")] TransactionItem transactionItem)
        {
            if (ModelState.IsValid)
            {
                db.TransactionItems.Add(transactionItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(transactionItem);
        }

        public ActionResult AddItems(Transaction transaction)
        {
            List<Movie> cartMovies = Session["Cart"] as List<Movie>;

            foreach(Movie m in cartMovies)
            {
                TransactionItem item = new TransactionItem(transaction.Id, m.Id);
                db.TransactionItems.Add(item);
                db.SaveChanges();
            }

            return RedirectToAction("Home", "Index");
        }

        // GET: TransactionItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionItem transactionItem = db.TransactionItems.Find(id);
            if (transactionItem == null)
            {
                return HttpNotFound();
            }
            return View(transactionItem);
        }

        // POST: TransactionItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TransactionId,MovieId")] TransactionItem transactionItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transactionItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transactionItem);
        }

        // GET: TransactionItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TransactionItem transactionItem = db.TransactionItems.Find(id);
            if (transactionItem == null)
            {
                return HttpNotFound();
            }
            return View(transactionItem);
        }

        // POST: TransactionItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TransactionItem transactionItem = db.TransactionItems.Find(id);
            db.TransactionItems.Remove(transactionItem);
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
