﻿using System;
using System.Collections;
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
       
        public string status { get; set; }

        public virtual Cart Cart {get; set;}

        public string userId { get; set; }

        public int AddressID { get; set; }
        public int CartID { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual Address Address { get; set; }

    }

}