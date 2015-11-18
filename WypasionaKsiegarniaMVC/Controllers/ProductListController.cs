using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ProductListController : Controller
    {
        // GET: Product
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {           
            ViewBag.listProducts = db.Products;
            return View();
        }
    }
}