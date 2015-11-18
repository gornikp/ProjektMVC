namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _7th : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        CartID = c.Int(nullable: false, identity: true),
                        userId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.CartID)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Street = c.String(nullable: false),
                        HouseNumber = c.Int(nullable: false),
                        LocalNumber = c.Int(nullable: false),
                        City = c.String(nullable: false),
                        PostCode = c.Int(nullable: false),
                        Country = c.String(nullable: false),
                        DateOfBirth = c.DateTime(nullable: false),
                        userId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.userId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CardNumber = c.Long(nullable: false),
                        userId = c.String(maxLength: 128),
                        AddressID = c.String(),
                        Address_AddressID = c.Int(),
                        Cart_CartID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID)
                .ForeignKey("dbo.Carts", t => t.Cart_CartID)
                .ForeignKey("dbo.AspNetUsers", t => t.userId)
                .Index(t => t.userId)
                .Index(t => t.Address_AddressID)
                .Index(t => t.Cart_CartID);
            
            AddColumn("dbo.CartItems", "Cart_CartID", c => c.Int());
            CreateIndex("dbo.CartItems", "Cart_CartID");
            AddForeignKey("dbo.CartItems", "Cart_CartID", "dbo.Carts", "CartID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "userId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Orders", "Cart_CartID", "dbo.Carts");
            DropForeignKey("dbo.Orders", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Carts", "userId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Addresses", "userId", "dbo.AspNetUsers");
            DropForeignKey("dbo.CartItems", "Cart_CartID", "dbo.Carts");
            DropIndex("dbo.Orders", new[] { "Cart_CartID" });
            DropIndex("dbo.Orders", new[] { "Address_AddressID" });
            DropIndex("dbo.Orders", new[] { "userId" });
            DropIndex("dbo.Addresses", new[] { "userId" });
            DropIndex("dbo.CartItems", new[] { "Cart_CartID" });
            DropIndex("dbo.Carts", new[] { "userId" });
            DropColumn("dbo.CartItems", "Cart_CartID");
            DropTable("dbo.Orders");
            DropTable("dbo.Addresses");
            DropTable("dbo.Carts");
        }
    }
}
