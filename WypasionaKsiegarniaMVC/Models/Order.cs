using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Order
    {
       
        
        [Display(Name = "Name")]
        [Required]
        public string Name { get; set; }

        
        [Display(Name = "Surname")]
        [Required]
        public string Surname { get; set; }

       
        [Display(Name = "Street")]
        [Required]
        public string Street { get; set; }

        
        [Display(Name = "House number")]
        [Required]
        public int HouseNumber { get; set; }

        
        [Display(Name = "Local number")]
        public int LocalNumber { get; set; }


        
        [Display(Name = "City")]
        [Required]
        public string City { get; set; }

        
        [Display(Name = "Postcode")]
        [Required]
        public int PostCode { get; set; }

      
        [Display(Name = "Country")]
        [Required]
        public string Country { get; set; }

        
        [CreditCard]
        [Required]
        [Range(1000000000000000, 9999999999999999, ErrorMessage = "Invalid number of card!")]
        [Display(Name = "Card number")]
        public long CardNumber { get; set; }


       /* public virtual ICollection<Picture> Pictures { get; set; }
        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Author> Authors { get; set; }*/

        //public virtual Cart cart; {get; set;}
        
    }

}