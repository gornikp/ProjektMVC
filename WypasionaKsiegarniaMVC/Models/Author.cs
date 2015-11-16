using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Author
    {
        [Key]
        public int AuthorsID { get; set; }

        [Display(Name = "Name")]
        public String Name { get; set; }

        [Display(Name = "Surname")]
        public String NameSurname { get; set; }

        public virtual ICollection<Product> Products { get; set; } 
    }
}
