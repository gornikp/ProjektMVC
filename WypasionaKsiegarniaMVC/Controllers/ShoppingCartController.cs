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
        

        private int isExisting(int id)
        {
            //db.Cart.Add((Cart)Session["cart"]);
            List<CartItem> cart = (List<CartItem>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
            
        }

        public ActionResult OrderNow(int id)
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
    }
}