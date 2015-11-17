namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3rd : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Discount", c => c.Double(nullable: false));
            AlterColumn("dbo.Products", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Products", "Discount", c => c.Int(nullable: false));
        }
    }
}
