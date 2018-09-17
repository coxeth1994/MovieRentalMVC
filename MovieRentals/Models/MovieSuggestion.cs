using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class MovieSuggestion
    {
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public int Id { get; set; }
            [Display(Name = "Full Name")]
            [Required]
            public string FullName { get; set; }
            [Required]
            [Display(Name = "Movie Suggestion")]
            public string Suggestion { get; set; }

            public MovieSuggestion() { }

            public MovieSuggestion(int id, string fullname, string suggestion)
            {
                Id = id;
                FullName = fullname;
                Suggestion = suggestion;
           }
    }
}