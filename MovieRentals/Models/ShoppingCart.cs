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

        public decimal CalculateTotal()
        {
            decimal total = 0.0m;

            for(int index = 0; index < Movies.Length; index++)
            {
                total += Movies[index].Cost;
            }

            return total;
        }
    }
}