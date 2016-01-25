using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
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

        public ActionResult Index(String searchString)
        {

            ViewBag.listProducts = db.Products.Where(x => x.Featured == true).ToList();
            ViewBag.Title = "Featured";

            if (!String.IsNullOrEmpty(searchString))
            {
                var products = db.Products.Include(p => p.Category).Include(p => p.Authors).Where(p => p.Hidden == false);
                products = products.Where(i => i.Title.Contains(searchString) || i.Publisher.Contains(searchString)
                     || i.Language.Contains(searchString));
                ViewBag.listProducts = products;
                ViewBag.Title = "Found";
            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.  ";

            return View();
        }

        public ActionResult Sent()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nice too meet you!";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async System.Threading.Tasks.Task<ActionResult> Contact(Email model)
        {
            ViewBag.Message = "Nice too meet you!";
            if (ModelState.IsValid)
            {
                var body = "<h2>Email From: {0} ({1})</h2></br><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("weronika.sawicka.9@gmail.com"));
                message.From = new MailAddress("weronika.sawicka.9@gmail.com");
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "weronika.sawicka.9@gmail.com",
                        Password = "Ptaszysko04464"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("/Sent");
                }
            }
            return View(model);
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
                    var ddad = db.Orders.Where(o => o.userId == idd).Include(o=>o.User).Include(o => o.Cart).Include(o=>o.Cart.CartItems);
                    ViewBag.order = ddad;
                    return View();
             }


             // GET: ApplicationUsers
             public ActionResult UsersRole()
             {
                 var users = db.Users.Include(o => o.Id).Include(o => o.Roles);
                 return View(users.ToList());
             }

    }
}