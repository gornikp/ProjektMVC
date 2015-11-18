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
        

        // GET: ShoppingCart
        public ActionResult Index()
        {
            return View();
        }
        private List<Product> Products = new List<Product>();

        private int isExisting(int id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)
                if (cart[i].Product.ProductID == id)
                    return i;
            return -1;
            
        }

        public ActionResult OrderNow(int id)
        {
            Product hp = new Product();
            Product e = new Product();
            hp.ISBN = 9394969399599;
            hp.Title = "Eloszka nad wodą";
            hp.StockAmount = 99;
            hp.Price = 80;
            hp.ProductID = 0;
            Products.Add(hp);
            e.ISBN = 1324364399566;
            e.Title = "Eloszka w niebie";
            e.StockAmount = 23;
            e.Price = 50;
            e.ProductID = 1;
            Products.Add(e);

            if (Session["cart"]==null)
            {
                
                List<Item> cart = new List<Item>();
                cart.Add(new Item(Products.Find(p => p.ProductID == id), 1));
                Session["cart"] = cart;
                
            }
            else
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(id);
                if (index == -1)
                    cart.Add(new Item(Products.Find(p => p.ProductID == id), 1));
                else
                    cart[index].Quantity += 1;
                Session["cart"] = cart;
            }
            return View("Cart");
        }
    }
}