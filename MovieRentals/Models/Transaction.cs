using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public Movie[] Movies { get; set; }
        public decimal Total { get; set; }
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