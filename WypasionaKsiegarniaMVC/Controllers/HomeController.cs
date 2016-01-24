using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;
using Microsoft.AspNet.Identity;

namespace WypasionaKsiegarniaMVC.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {

            ViewBag.listProducts = db.Products.Where(x => x.Featured == true).ToList();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.  ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Motyw(int id)
        {

            switch (id)
            {
                case 1:
                    MvcApplication.theme = "bootstrap.min.css";
                    break;
                case 2:
                    MvcApplication.theme = "bootstrap4.min.css";
                    break;

                case 3:
                    MvcApplication.theme = "bootstrap2.min.css";
                    break;
            }


            return RedirectToAction("Index", "Home");

        }
    
             public ActionResult Userpanel()
             {
            string idd = User.Identity.GetUserId().ToString();
            var orders = db.Orders.Include(o => o.Cart).Where(o=>o.userId==idd);
            var ddad = db.Orders.Where(o => o.userId == idd).Include(o=>o.User).Include(o => o.Cart);
            ViewBag.order = ddad;
            return View();
             }

}
}