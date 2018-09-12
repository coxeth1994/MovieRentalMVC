using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class ShoppingCart
    {
        public List<Movie> Movies { get; set; }
        public decimal Total { get; set; }

        public ShoppingCart() { }
        public ShoppingCart(List<Movie> theMovies)
        {
            Movies = theMovies;
            
        }

        public void CalculateTotal()
        {
            decimal total = 0.0m;

            foreach(Movie m in Movies)
            {
                total += m.Cost;
            }

            Total = total;
        }
    }
}