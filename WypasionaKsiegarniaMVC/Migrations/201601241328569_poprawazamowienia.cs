namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poprawazamowienia : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Orders", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Orders", "Cart_CartID", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "Address_AddressID" });
            DropIndex("dbo.Orders", new[] { "Cart_CartID" });
            DropColumn("dbo.Orders", "AddressID");
            RenameColumn(table: "dbo.Orders", name: "Address_AddressID", newName: "AddressID");
            RenameColumn(table: "dbo.Orders", name: "Cart_CartID", newName: "CartID");
            AlterColumn("dbo.Orders", "AddressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "AddressID", c => c.Int(nullable: false));
            AlterColumn("dbo.Orders", "CartID", c => c.Int(nullable: false));
            CreateIndex("dbo.Orders", "AddressID");
            CreateIndex("dbo.Orders", "CartID");
            AddForeignKey("dbo.Orders", "AddressID", "dbo.Addresses", "AddressID", cascadeDelete: true);
            AddForeignKey("dbo.Orders", "CartID", "dbo.Carts", "CartID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "CartID", "dbo.Carts");
            DropForeignKey("dbo.Orders", "AddressID", "dbo.Addresses");
            DropIndex("dbo.Orders", new[] { "CartID" });
            DropIndex("dbo.Orders", new[] { "AddressID" });
            AlterColumn("dbo.Orders", "CartID", c => c.Int());
            AlterColumn("dbo.Orders", "AddressID", c => c.Int());
            AlterColumn("dbo.Orders", "AddressID", c => c.String());
            RenameColumn(table: "dbo.Orders", name: "CartID", newName: "Cart_CartID");
            RenameColumn(table: "dbo.Orders", name: "AddressID", newName: "Address_AddressID");
            AddColumn("dbo.Orders", "AddressID", c => c.String());
            CreateIndex("dbo.Orders", "Cart_CartID");
            CreateIndex("dbo.Orders", "Address_AddressID");
            AddForeignKey("dbo.Orders", "Cart_CartID", "dbo.Carts", "CartID");
            AddForeignKey("dbo.Orders", "Address_AddressID", "dbo.Addresses", "AddressID");
        }
    }
}
