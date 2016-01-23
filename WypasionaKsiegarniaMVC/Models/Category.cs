using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public int FatherID { get; set; }
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }
        public int FatherMainID { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}