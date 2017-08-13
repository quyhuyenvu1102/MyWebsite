using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyWebsite.Models.API
{
    public class ApiDbContext : DbContext,IApiDbContext
    {
        public ApiDbContext() : this("IceCreamAPIConnection") { }

        public ApiDbContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderItem> OrderItems { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Salesperson> Salesperson { get; set; }
        

    }
}