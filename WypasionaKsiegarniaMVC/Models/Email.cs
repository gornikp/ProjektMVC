﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Email
    {
        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Required, Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        public string AboutProduct { get; set; }
        [Required]
        public string Message { get; set; }
    }
}