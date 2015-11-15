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
        public ICollection <String> Author { get; set; }

        [Display(Name = "Language")]  //lel spell checker was really useful for the first time here :D
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

        [Display(Name = "Amount")]
        public String StockAmount { get; set; }

        [Display(Name = "Pictures")]
        public ICollection <Uri> Pictures { get; set; }//
                                                       // Nie jestem pewnien czy tak jest dobrze czy nie trzeba tworzyć nowej Klasy "Obrazki" "autorzy" "pliki" itd.
        [Display(Name = "Files")]                      //
        public ICollection<Uri> Files { get; set; }    //

        [Display(Name = "Featured")]
        public bool Featured { get; set; }

        [Display(Name = "Discount")]
        public int Discount { get; set; }

        [Display(Name = "Hidden")]
        public bool Hidden { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}