using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypasionaKsiegarniaMVC.Models
{
                         /*
                         * Mechanizm Migrations
                         * 
                         * 1. W Package Manager Console wlaczyc migracje: enable-migrations
                         * 2. Stworzenie wersji bazy add-migration nazwa_migracji
                         * 3. Naniesie zmian na baze: update-database
                         */
    class Product_DbContext : DbContext
    {
        public Product_DbContext() : base("MyCS") { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Author> Authors { get; set; }

    }
}
