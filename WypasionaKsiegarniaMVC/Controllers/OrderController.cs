using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class OrderController : Controller
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
       //private ShoppingCartController cartShopping = new ShoppingCartController();
        
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
       
        // GET: Order/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: Order/Create
        public ActionResult Create(ShoppingCartController cartShopping)
        {
            //List<Item> cart = new List<Item>();
           // cart= Session['cart'];
            return View();
        }

        
        // POST: Order/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Order/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Order/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Order/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
