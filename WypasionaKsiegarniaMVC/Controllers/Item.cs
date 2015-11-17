using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    class Item
    {
        private Product product = new Product();
        private int quantity;
        public int Quantity { get { return quantity; } set { quantity = value; } }
        public Product Product { get { return product; } set { product = value; } }

        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

    }
}
