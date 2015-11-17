namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4th : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Products", "FileID");
            DropColumn("dbo.Products", "PictureID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "PictureID", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "FileID", c => c.Int(nullable: false));
        }
    }
}
