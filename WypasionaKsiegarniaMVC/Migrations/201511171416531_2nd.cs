namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _2nd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Files", "Address", c => c.String());
            AddColumn("dbo.Pictures", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pictures", "Address");
            DropColumn("dbo.Files", "Address");
        }
    }
}
