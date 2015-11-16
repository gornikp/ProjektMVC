﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Picture
    {
        public int PictureID { get; set; }
        [Display(Name = "Address")]
        public Uri Address { get; set; }


        public virtual Product Product { get; set; }
    }
}