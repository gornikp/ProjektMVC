namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza_kategorie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "discount", c => c.Int(nullable: false));
            AddColumn("dbo.AspNetUsers", "newsletter", c => c.Boolean(nullable: false));
            AddColumn("dbo.Products", "CategoryID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CategoryID");
            DropColumn("dbo.AspNetUsers", "newsletter");
            DropColumn("dbo.AspNetUsers", "discount");
        }
    }
}
