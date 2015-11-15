using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Product
    {
        [Display(Name = "ISBN")]
        [Range(1000000000, 9999999999999, ErrorMessage = "Wrong ISBN number!")]
        public long ISBN { get; set; }

        [Display(Name = "Title")]
        public String Title { get; set; }

        [Display(Name = "Author")]
        public String Author { get; set; }

        [Display(Name = "Lanuage")]
        public String Language { get; set; }

        [Display(Name = "Price")]
        public Double Price { get; set; }

        [Display(Name = "Year")]
        [Range(1, 2015, ErrorMessage = "Invalid Date!")]
        public int Year { get; set; }

        [Display(Name = "Publisher")]
        public String Publisher { get; set; }

        [Display(Name = "Page amount")]
        [Range(0, 100000, ErrorMessage = "Invalid number of pages!")]
        public int PageAmount { get; set; }

        [Display(Name = "Format")]
        public String Format { get; set; }
    }
}