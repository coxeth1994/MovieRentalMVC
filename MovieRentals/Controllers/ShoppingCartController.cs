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
            List<int> cartMovies = Session["Cart"] as List<int>;

            foreach(int id in cartMovies)
            {
                ViewData[id.ToString()] = id;
            }
            return View();
        }
    }
}