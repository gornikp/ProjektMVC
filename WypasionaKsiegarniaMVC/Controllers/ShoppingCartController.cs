using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        private List<Product> Products = new List<Product>();
        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OrderNow(int id)
        {
            if (Session["cart"]==null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(Products.Find(p => p.ProductID == id), 1));
                Session["cart"] = cart;
            }
            else
            {

            }
            return View("Cart");
        }
    }
}