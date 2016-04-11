using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace u1265196_MovieRentals.Models
{
    public class Movies
    {
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        [Display(Name = "Length of film")]
        public string Length { get; set; }
        [Required]
        public int AgeRating { get; set; }

    }
}