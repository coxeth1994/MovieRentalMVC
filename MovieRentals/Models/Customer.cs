using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieRentals.Models
{
    public class Customer
    {
        public Boolean type { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string billingAddress { get; set; }
        public int ccNum { get; set; }
        public int cvvNum { get; set; }
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
