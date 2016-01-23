using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View("Cart");
        }
        public ActionResult CartBin()
        {
            return View("CartBin");
        }


        private int isExisting(int id)
        {
            //db.Cart.Add((Cart)Session["cart"]);
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
            
        }
        private int isExisting2(int id)
        {
            //db.Cart.Add((Cart)Session["cart"]);
            List<CartItem> cart = (List<CartItem>)Session["cartbin"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;

        }

        public ActionResult OrderNow(int id) //Add to cart
        {

            if (Session["cart"]==null)
            {
                
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(db.Products.Find(id), 1));
                Session["cart"] = cart;
                
            }
            else
            {
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new CartItem(db.Products.Find(id), 1));
                else
                    cart[index].Quantity += 1;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult Remove(int id) //Add to cart
        {
            int index = isExisting(id);
            List<CartItem> cart = (List<CartItem>)Session["cart"];

            if (Session["cartbin"] == null)
            {

                List<CartItem> cartbin = new List<CartItem>();
                cartbin.Add(new CartItem(db.Products.Find(id), 1));
                Session["cartbin"] = cartbin;

            }
            else
            {
                List<CartItem> cartbin = (List<CartItem>)Session["cartbin"];
                int index2 = isExisting2(id);
                if (index2 == -1)
                    cartbin.Add(new CartItem(db.Products.Find(id), amount(id)));
                else
                    cartbin[index2].Quantity += amount(id);
                Session["cartbin"] = cartbin;
            }
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("CartBin");
        }
        private int amount(int id)
        {
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            foreach (CartItem item in cart)
            {
                if (item.Product.ProductID==id)
                {
                   return item.Quantity;
                }
            }
            return 0;
        }
    }
}