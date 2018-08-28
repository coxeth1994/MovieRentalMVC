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
        [Display(Name = "Id")]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Registered")]
        public Boolean type { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string email { get; set; }
        [Required]
        [Display(Name = "Phone")]
        public int phone { get; set; }
        [Required]
        [Display(Name = "Billing Address")]
        public string billingAddress { get; set; }
        [Required]
        [Display(Name = "Credit Card #")]
        public int ccNum { get; set; }
        [Required]
        [Display(Name = "CVV #")]
        public int cvvNum { get; set; }
        [Required]
        [Display(Name = "Expiration Date")]
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
