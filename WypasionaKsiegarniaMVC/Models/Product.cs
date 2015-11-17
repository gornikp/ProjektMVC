using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Display(Name = "ISBN")]
        [Range(1000000000, 9999999999999, ErrorMessage = "Wrong ISBN number!")]
        public long ISBN { get; set; }

        [Display(Name = "Title")]
        [Required]
        public String Title { get; set; }

        [Display(Name = "Language")]
        [Required]
        public String Language { get; set; }

        [Display(Name = "Price")]
        public Double Price { get; set; }

        [Display(Name = "Year")]
        [Range(1500, 2015, ErrorMessage = "Invalid Date!")]
        public int Year { get; set; }

        [Display(Name = "Publisher")]
        [Required]
        public String Publisher { get; set; }

        [Display(Name = "Page amount")]
        [Range(0, 100000, ErrorMessage = "Invalid number of pages!")]
        public int PageAmount { get; set; }

        [Display(Name = "Format")]
        [Required]
        public String Format { get; set; }

        [Display(Name = "Amount")]
        [Range(0, 100000, ErrorMessage = "Invalid number of pages!")]
        [Required]
        public int StockAmount { get; set; }

        [Display(Name = "Featured")]
        public bool Featured { get; set; }

        [Display(Name = "Discount")]
        public double Discount { get; set; }

        [Display(Name = "Hidden")]
        public bool Hidden { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}