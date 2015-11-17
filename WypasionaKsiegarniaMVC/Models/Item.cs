namespace WypasionaKsiegarniaMVC.Models
{
    public class Item
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
