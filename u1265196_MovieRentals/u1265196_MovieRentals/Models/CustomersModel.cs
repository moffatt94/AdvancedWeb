using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel.DataAnnotations;


namespace u1265196_MovieRentals.Models
{
    public class Customers
    {
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Required]
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }
        [Required]
        [Display(Name = "Postcode")]
        public string Postcode { get; set; }
        [Required]
        [Display(Name = "Phone No")]
        public string Phone { get; set; }

    }
}

