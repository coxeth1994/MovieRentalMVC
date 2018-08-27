using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public Employee() { }

        public Employee(int id, string firstName, string lastName, string email)
        {
            Id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
        }
    }
}