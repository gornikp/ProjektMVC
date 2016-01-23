namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza_kategoriefinale2311 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "Category_CategoryID" });
            DropColumn("dbo.Products", "Category_CategoryID");
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        FatherID = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        FatherMainID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            AddColumn("dbo.Products", "Category_CategoryID", c => c.Int());
            CreateIndex("dbo.Products", "Category_CategoryID");
            AddForeignKey("dbo.Products", "Category_CategoryID", "dbo.Categories", "CategoryID");
        }
    }
}
