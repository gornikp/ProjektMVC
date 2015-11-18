namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _9th : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProductAuthors", newName: "AuthorProducts");
            DropPrimaryKey("dbo.AuthorProducts");
            AddPrimaryKey("dbo.AuthorProducts", new[] { "Author_AuthorsID", "Product_ProductID" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AuthorProducts");
            AddPrimaryKey("dbo.AuthorProducts", new[] { "Product_ProductID", "Author_AuthorsID" });
            RenameTable(name: "dbo.AuthorProducts", newName: "ProductAuthors");
        }
    }
}
