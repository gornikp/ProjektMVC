namespace WypasionaKsiegarniaMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class poprawazamowienia2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CartItems", "Cart_CartID", "dbo.Carts");
            DropIndex("dbo.CartItems", new[] { "Cart_CartID" });
            DropColumn("dbo.CartItems", "CartID");
            RenameColumn(table: "dbo.CartItems", name: "Cart_CartID", newName: "CartID");
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "ItemID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CartItems", "CartID", c => c.Int(nullable: false));
            AlterColumn("dbo.CartItems", "CartID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CartItems", "ItemID");
            CreateIndex("dbo.CartItems", "CartID");
            AddForeignKey("dbo.CartItems", "CartID", "dbo.Carts", "CartID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartItems", "CartID", "dbo.Carts");
            DropIndex("dbo.CartItems", new[] { "CartID" });
            DropPrimaryKey("dbo.CartItems");
            AlterColumn("dbo.CartItems", "CartID", c => c.Int());
            AlterColumn("dbo.CartItems", "CartID", c => c.String());
            AlterColumn("dbo.CartItems", "ItemID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.CartItems", "ItemID");
            RenameColumn(table: "dbo.CartItems", name: "CartID", newName: "Cart_CartID");
            AddColumn("dbo.CartItems", "CartID", c => c.String());
            CreateIndex("dbo.CartItems", "Cart_CartID");
            AddForeignKey("dbo.CartItems", "Cart_CartID", "dbo.Carts", "CartID");
        }
    }
}
