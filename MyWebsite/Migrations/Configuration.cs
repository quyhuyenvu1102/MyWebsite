namespace MyWebsite.Migrations
{
    using MyWebsite.Models.API;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyWebsite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(MyWebsite.Models.ApplicationDbContext _context)
        {
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU99",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });

            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU01",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU02",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU03",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU04",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU05",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU06",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU07",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU08",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU09",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU10",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU11",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });
            _context.Products.AddOrUpdate(new Product()
            {
                ProductId = "MWBLU12",
                ProductName = "Super Mineral Water",
                Size = "Medium",
                Variety = "Blueberry",
                Price = 979,
                Status = "ACTIVE"
            });

            //------seed customers-------
            _context.Customers.AddOrUpdate(new Customer()
            {
                CustomerId = 1,
                FirstName = "Johny",
                LastName = "Sullivan",
                Phone = "204 428 0636",
                Address = "1931 West London",
                City = "London",
                State = "MD",
                Zipcode = "20851",
                Email = "Johny@gmail.com"
            });

            _context.Customers.AddOrUpdate(new Customer()
            {
                CustomerId = 2,
                FirstName = "Johny",
                LastName = "Sullivan",
                Phone = "204 428 0636",
                Address = "1931 West London",
                City = "London",
                State = "MD",
                Zipcode = "20851",
                Email = "Johny@gmail.com"
            });

            //-- seed Salesperson---
            _context.Salesperson.AddOrUpdate(new Salesperson()
            {
                SalespersonId = 1,
                FirstName = "Johny",
                LastName = "Sullivan",
                Phone = "204 428 0636",
                Address = "1931 West London",
                City = "London",
                State = "MD",
                Zipcode = "20851",
                Email = "Johny@gmail.com"
            });

            _context.Orders.AddOrUpdate(new Order()
            {
                OrderId = 1,
                CustomerId = 1,
                Date = DateTime.Now,
                SalespersonId = 1,
                Status = "paid",
                TotalDue = 9900
            });

            _context.OrderItems.AddOrUpdate(new OrderItem()
            {
                OrderId = 1,
                OrderItemId = 1,
                ProductId = "MWBLU10",
                Quantity = 3
            });

            _context.SaveChanges();
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
