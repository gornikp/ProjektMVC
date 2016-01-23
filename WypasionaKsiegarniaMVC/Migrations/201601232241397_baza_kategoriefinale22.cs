namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class baza_kategoriefinale22 : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Categories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        FatherID = c.Int(nullable: false),
                        FatherMainID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
    }
}
