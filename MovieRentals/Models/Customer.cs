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
        public Boolean Type { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int Phone { get; set; }
        [Required]
        public string BillingAddress { get; set; }
        [Required]
        public int CcNum { get; set; }
        [Required]
        public int CvvNum { get; set; }
        [Required]
        public string ExpDate { get; set; }


        public Customer() { }

        public Customer(bool type, string firstName, string lastName, string email, int phone, string billingAddress, int ccNum, int cvvNum, string expDate)
        {
            this.Type = type;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Phone = phone;
            this.BillingAddress = billingAddress;
            this.CcNum = ccNum;
            this.CvvNum = cvvNum;
            this.ExpDate = expDate;
        }

    }
}
