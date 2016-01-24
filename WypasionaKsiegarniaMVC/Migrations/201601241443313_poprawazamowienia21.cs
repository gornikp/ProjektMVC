namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poprawazamowienia21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "status", c => c.String());
            DropColumn("dbo.Orders", "CardNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "CardNumber", c => c.Long(nullable: false));
            DropColumn("dbo.Orders", "status");
        }
    }
}
