using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WypasionaKsiegarniaMVC.Models;

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class AddProductController : Controller
    {
        private List<Product> products = new List<Product>();

        // GET: AddProduct
        public ActionResult List()
        {
            if(products.Count == 0)
            {
                Product p = new Product();
                p.Description = "Nice book, you should read.";
                p.Discount = 0;
                p.Format = "normal";
                p.ISBN = 12312312340;
                p.Language = "english";
                p.PageAmount = 1000;
                p.Price = 56.50;
                p.Pictures.Add(new Picture("http://weknowyourdreams.com/image.php?pic=/images/book/book-06.jpg"));
                p.Pictures.Add(new Picture("http://www.bradleysbookoutlet.com/wp-content/uploads/2013/06/bradleys-book-outlet-books-only-logo.png"));
                p.Publisher = "Book4You";
                p.StockAmount = 10;
                p.Title = "Back And Again.";
                p.Year = 2013;
                products.Add(p);
            }
            return View(products.ToList());
        }

        // GET: AddProduct/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AddProduct/Create
        public ActionResult Create()
        {
            return View(products.ToList());
        }

        // POST: AddProduct/Create
        [HttpPost]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                products.Add(product);
                ViewBag.Message = "Product saved.";
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Message = "Error: " + ModelState.Values;
                return View(product);
            }
        }

        // GET: AddProduct/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AddProduct/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("List");
            }
            return View(product);
        }

        // GET: AddProduct/Delete/5
        public ActionResult Delete(int id)
        {
            return View(products.ToList());
        }

        // POST: AddProduct/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Product product)
        {
            products.Remove(product);
            return RedirectToAction("List");
        }
    }
}
