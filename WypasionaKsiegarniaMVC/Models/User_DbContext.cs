using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{

        public class MyDbContext : IdentityDbContext
        {
            public MyDbContext() : base("MyCS")
            {

            }
        }
}
