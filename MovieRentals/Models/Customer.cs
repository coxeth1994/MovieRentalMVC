using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    [Table("Customer")]
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public Boolean type { get; set; }
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int phone { get; set; }
        [Required]
        public string billingAddress { get; set; }
        [Required]
        public int ccNum { get; set; }
        [Required]
        public int cvvNum { get; set; }
        [Required]
        public string expDate { get; set; }


        public Customer() { }

        public Customer(bool type, string firstName, string lastName, string email, int phone, string billingAddress, int ccNum, int cvvNum, string expDate)
        {
            this.type = type;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.billingAddress = billingAddress;
            this.ccNum = ccNum;
            this.cvvNum = cvvNum;
            this.expDate = expDate;
        }

    }
}
}