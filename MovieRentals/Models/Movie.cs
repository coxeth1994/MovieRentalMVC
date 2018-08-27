using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    [Table("Movie")]
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public decimal Cost { get; set; }
        [Required]
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