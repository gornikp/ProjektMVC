using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Picture
    {
        public Picture(string link)
        {
            this.Address = link;
        }

        public int PictureID { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }
    }
}
