using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    [Table("Transaction")]
    public class Transaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public Movie[] Movies { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        public Transaction() { }

        public Transaction(int id, Customer customer, Movie[] movies, decimal total, DateTime orderDate)
        {
            Id = id;
            Customer = customer;
            Movies = movies;
            Total = total;
            OrderDate = orderDate;
        }
    }
}