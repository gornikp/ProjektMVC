using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Order
    {
       [Key]
       public int OrderID { get; set; }
        
        [CreditCard]
        [Required]
        [Range(1000000000000000, 9999999999999999, ErrorMessage = "Invalid number of card!")]
        [Display(Name = "Card number")]
        public long CardNumber { get; set; }

        public virtual Cart Cart {get; set;}

        public string userId { get; set; }

        public int AddressID { get; set; }
        public int CartID { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual Address Address { get; set; }

    }

}