namespace MyWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 30),
                        LastName = c.String(maxLength: 30),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(),
                        City = c.String(maxLength: 20),
                        State = c.String(),
                        Zipcode = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        TotalDue = c.Int(nullable: false),
                        Status = c.String(),
                        CustomerId = c.Int(nullable: false),
                        SalespersonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Salespersons", t => t.SalespersonId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.SalespersonId);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        OrderItemId = c.Int(nullable: false, identity: true),
                        Quantity = c.Int(nullable: false),
                        OrderId = c.Int(nullable: false),
                        ProductId = c.Guid(nullable: false),
                        Product_ProductId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.OrderItemId)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.Product_ProductId)
                .Index(t => t.OrderId)
                .Index(t => t.Product_ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        Size = c.String(),
                        Variety = c.String(),
                        Price = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Salespersons",
                c => new
                    {
                        SalespersonId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 20),
                        LastName = c.String(maxLength: 20),
                        Email = c.String(),
                        Phone = c.String(),
                        Address = c.String(maxLength: 20),
                        City = c.String(maxLength: 20),
                        State = c.String(maxLength: 20),
                        Zipcode = c.String(),
                    })
                .PrimaryKey(t => t.SalespersonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "SalespersonId", "dbo.Salespersons");
            DropForeignKey("dbo.OrderItems", "Product_ProductId", "dbo.Products");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerId", "dbo.Customers");
            DropIndex("dbo.OrderItems", new[] { "Product_ProductId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "SalespersonId" });
            DropIndex("dbo.Orders", new[] { "CustomerId" });
            DropTable("dbo.Salespersons");
            DropTable("dbo.Products");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.Customers");
        }
    }
}
