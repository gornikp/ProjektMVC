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
        public File (string address)
        {
            this.Address = address;
        }
        public int FileID { get; set; }
        [Display(Name = "Files")]
        public string Address { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
