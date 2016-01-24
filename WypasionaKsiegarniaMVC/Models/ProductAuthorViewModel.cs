using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WypasionaKsiegarniaMVC.Models
{
    public class ProductAuthorViewModel
    {
        public Product Product { get; set; }
        public IEnumerable<SelectListItem> AllAuthorsList { get; set; }

        private List<int> _selectedAuthors;
        public List<int> SelectedAuthors
        {
            get
            {
                if (_selectedAuthors == null)
                {
                    _selectedAuthors = Product.Authors.Select(i => i.AuthorsID).ToList();
                }
                return _selectedAuthors;
            }
            set { _selectedAuthors = value; }
        }
    }
}