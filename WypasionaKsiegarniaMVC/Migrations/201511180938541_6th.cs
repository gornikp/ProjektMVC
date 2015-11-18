namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _6th : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.CartItems", new[] { "ProductId" });
            CreateIndex("dbo.CartItems", "ProductID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.CartItems", new[] { "ProductID" });
            CreateIndex("dbo.CartItems", "ProductId");
        }
    }
}
