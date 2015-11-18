namespace WypasionaKsiegarniaMVC.Models
{
    public class Item
    {
        public Product Product {get; set;}
        public int Quantity { get; set; }
        public Item()
        {

        }

        public Item(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

    }
}
