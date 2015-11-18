using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
    public class Address
    {
        [Key]
        public int AddressID { get; set; } 

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

        [Display(Name = "Birth Date")]
        [Required]
        public DateTime? DateOfBirth { get; set; }

        public string userId { get; set; }

        public virtual ApplicationUser User { get; set;  }
    }
}
