using MovieRentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieRentals.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            List<Movie> cartMovies = Session["Cart"] as List<Movie>;
            if(cartMovies != null && cartMovies.Count != 0)
            {
                ShoppingCart movies = new ShoppingCart(cartMovies);
                movies.CalculateTotal();
                ViewData["Total"] = movies.Total;
                this.Session["Total"] = ViewData["Total"];
                ViewData["Cart"] = this.Session["Cart"];


                return View();
            } else
            {
                return RedirectToAction("Empty");
            }
        }

        public ActionResult Empty()
        {
            return View();
        }

        public ActionResult Delete(int id)
        {
            List<Movie> cartMovies = Session["Cart"] as List<Movie>;

            foreach(Movie movie in cartMovies)
            {
                if(movie.Id == id)
                {
                    cartMovies.Remove(movie);
                    break;
                }
            }

            Session["Cart"] = cartMovies;

            return RedirectToAction("Index");
        }

        public ActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Checkout([Bind(Include = "Id,Type,FirstName,LastName,Email,Phone,BillingAddress,CcNum,CvvNum,ExpDate")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(customer);
                db.SaveChanges();
                int id = customer.Id;
                decimal total = (decimal)Session["Total"];
                return RedirectToAction("AddTransaction", "Transactions", new { customerId = customer.Id, type = customer.type, fName = customer.firstName, lname = customer.lastName, email = customer.email, phone = customer.phone, bill = customer.billingAddress, cc = customer.ccNum, cvv = customer.cvvNum, exp = customer.expDate, total = total});
            }

            return RedirectToAction("Checkout");
        }

        public ActionResult ThankYou()
        {
            return View();
        }
    }
}