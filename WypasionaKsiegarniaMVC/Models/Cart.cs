﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Cart
    {
        [Key]
        public int CartID {get; set;}

        public virtual ICollection<CartItem> CartItems { get; set; }

        public string userId { get; set; }

        public virtual ApplicationUser user { get; set; }

        //public string UseriD dodac id usera
    }
}
