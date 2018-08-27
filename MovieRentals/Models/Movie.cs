using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public int Year { get; set; }
        public decimal Cost { get; set; }
        public string Rating { get; set; }
        public int RentalDuration { get; set; }

        public Movie()
        {
        }
        public Movie(int theId, string theGenre, string theDirector, int theYear, decimal theCost, string theRating, int theRentalDuration)
        {
            Id = theId;
            Genre = theGenre;
            Director = theDirector;
            Year = theYear;
            Cost = theCost;
            Rating = theRating;
            RentalDuration = theRentalDuration;
        }
    }
}