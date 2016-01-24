using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WypasionaKsiegarniaMVC.Models
{
    public class CartItem
    {
       
        [Key]
        public int ItemID { get; set; }

        public int CartID { get; set; }

        public System.DateTime DateCreated { get; set; }

        public int ProductID { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public CartItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }
        public CartItem()
        { }

    }
}
