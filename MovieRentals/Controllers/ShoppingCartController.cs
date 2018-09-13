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
        // GET: ShoppingCart
        public ActionResult Index()
        {
            List<Movie> cartMovies = Session["Cart"] as List<Movie>;
            if(cartMovies != null && cartMovies.Count != 0)
            {
                ShoppingCart movies = new ShoppingCart(cartMovies);
                movies.CalculateTotal();
                ViewData["Total"] = movies.Total;
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
    }
}