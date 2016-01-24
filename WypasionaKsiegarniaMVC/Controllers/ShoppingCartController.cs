using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;
using System.Runtime.InteropServices;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            IdentityManager elo = new IdentityManager();

            
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
        public ActionResult OrderNow([Optional]int id, [Optional]int quantity) //Add to cart
        {
            if(quantity == 0 || id == 0)
            {
                return View("Cart");
            }

            if (Session["cart"]==null)
            {
                
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(db.Products.Find(id), quantity));
                Session["cart"] = cart;
                
            }
            else
            {
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new CartItem(db.Products.Find(id), quantity));
                else
                    cart[index].Quantity += quantity;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
        public ActionResult OrderNow2(int? id,int? amount) //Add to cart
        {
            if (amount == null || id == null)
            {
                return View("Cart");
            }

            if (Session["cart"] == null)
            {

                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem(db.Products.Find(id), (int)amount));
                Session["cart"] = cart;

            }
            else
            {            
                List<CartItem> cart = (List<CartItem>)Session["cart"];
                int index = isExisting((int)id);
                if (index == -1)
                    cart.Add(new CartItem(db.Products.Find(id), (int)amount));
                else
                    cart[index].Quantity += (int)amount;
                Session["cart"] = cart;
            }
            List<CartItem> cart2 = new List<CartItem>();
            cart2 = (List<CartItem>)Session["cartbin"];
            int index2 = isExisting2((int)id);
            cart2.RemoveAt(index2);
            return View("Cart");
        }
        public ActionResult Remove(int id,int quantity) //Add to cart
        {
            int index = isExisting(id);
            List<CartItem> cart = (List<CartItem>)Session["cart"];

            if (Session["cartbin"] == null)
            {

                List<CartItem> cartbin = new List<CartItem>();
                cartbin.Add(new CartItem(db.Products.Find(id), quantity));
                Session["cartbin"] = cartbin;

            }
            else
            {
                List<CartItem> cartbin = (List<CartItem>)Session["cartbin"];
                int index2 = isExisting2(id);
                if (index2 == -1)
                    cartbin.Add(new CartItem(db.Products.Find(id), quantity));
                else
                    cartbin[index2].Quantity += quantity;
                Session["cartbin"] = cartbin;
            }
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return View("CartBin");
        }     
    }
}