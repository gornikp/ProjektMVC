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

namespace WypasionaKsiegarniaMVC.Controllers
{
    public class ProductsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Products
        public async Task<ActionResult> Index()
        {
            var products = db.Products.Include(p => p.Category).Include(p=>p.Authors).Where(p=>p.Hidden==false);
            return View(await products.ToListAsync());
        }
        public ActionResult List()
        {
            var products = db.Products.Include(p => p.Category).Include(p => p.Authors);
            return View(products.ToList());
        }

        // GET: Products/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Name");
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ProductID,ISBN,Title,Authors,Language,Price,Year,Publisher,PageAmount,Format,StockAmount,Featured,Discount,Hidden,Description,CategoryID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Featured
        public ActionResult Featured()
        {
            int maxId = db.Products.Max(i => i.ProductID);
            IEnumerable <Product> news = (db.Products.ToList()).Where(i => i.ProductID > maxId - 6);
            IEnumerable <Product> discounts = (db.Products.ToList()).Where(i => i.Featured = true & i.Discount < 1);
            ViewBag.News = news;
            ViewBag.Discounts = discounts;

            return View();
        }

        // GET: Products/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Product product = await db.Products.FindAsync(id);
            var productAuthorViewModel = new ProductAuthorViewModel
            {
                Product = db.Products.Include(i => i.Authors).First(i => i.ProductID == id),
            };

            if (productAuthorViewModel.Product == null)
            {
                return HttpNotFound();
            }

            var allAuthorsList = db.Authors.ToList();
            productAuthorViewModel.AllAuthorsList = allAuthorsList.Select(i => new SelectListItem { Text = i.Name + " " + i.NameSurname, Value=i.AuthorsID.ToString() });

            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Name", productAuthorViewModel.Product.CategoryID);
            ViewBag.AuthorId = new SelectList(db.Authors, "AuthorsId", "Name", "NameSurname",  productAuthorViewModel.Product.ProductID);
            return View(productAuthorViewModel);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ProductID,ISBN,Title,Authors,Language,Price,Year,Publisher,PageAmount,Format,StockAmount,Featured,Discount,Hidden,Description,CategoryID")] Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryID = new SelectList(db.Categories, "CategoryID", "Name", product.CategoryID);
            return View(product);
        }

        // GET: Products/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product product = await db.Products.FindAsync(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Product product = await db.Products.FindAsync(id);
            db.Products.Remove(product);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
