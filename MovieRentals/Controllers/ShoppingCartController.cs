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
            if(cartMovies != null)
            {
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
    }
}