namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza_kategorie21 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "Name", c => c.String());
            AddColumn("dbo.Pictures", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pictures", "Name");
            DropColumn("dbo.Files", "Name");
        }
    }
}
