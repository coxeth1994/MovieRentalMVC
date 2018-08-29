using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    [Table("Suggestion")]
    public class Suggestion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public string MovieSuggestion { get; set; }

        public Suggestion() { }

        public Suggestion(int id, Customer customer, string suggestion)
        {
            Id = id;
            Customer = customer;
            MovieSuggestion = suggestion;
        }
    }
}