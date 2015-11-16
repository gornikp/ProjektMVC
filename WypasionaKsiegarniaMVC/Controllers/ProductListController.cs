using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ProductListController : Controller
    {
        // GET: Product
        private List<Product> Products = new List<Product>();
        public ActionResult Index()
        {

            Product p = new Product();
            Product e = new Product();
            p.ISBN = 9394969399599;
            p.Title = "Eloszka nad wodą";
            p.StockAmount = 99;
            p.Price = 80;
            Products.Add(p);
            e.ISBN = 1324364399566;
            e.Title = "Eloszka w niebie";
            e.StockAmount = 23;
            e.Price = 50;
            Products.Add(e);
            ViewBag.listProducts = Products;
            return View();
        }
    }
}