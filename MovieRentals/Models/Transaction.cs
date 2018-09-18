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
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public decimal Total { get; set; }
        [Required]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        public Transaction() { }

        public Transaction(Customer customer, decimal total, DateTime orderDate)
        {
            Customer = customer;
            Total = total;
            OrderDate = orderDate;
        }
    }
}