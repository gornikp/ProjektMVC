using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class File
    {
        public int FileID { get; set; }
        [Display(Name = "Link")]
        public string Address { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
