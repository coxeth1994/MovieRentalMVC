using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class ShoppingCart
    {
        public Movie[] Movies { get; set; }
        public decimal Total { get; set; }

        public ShoppingCart() { }
        public ShoppingCart(Movie[] theMovies, decimal theTotal)
        {
            Movies = theMovies;
            Total = theTotal;
        }
    }
}