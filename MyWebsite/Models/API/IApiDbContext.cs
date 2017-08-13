using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Models.API
{
    public interface IApiDbContext
    {
        IDbSet<Customer> Customers { get; set; }

        IDbSet<Order> Orders { get; set; }

        IDbSet<OrderItem> OrderItems { get; set; }

        IDbSet<Product> Products { get; set; }

        IDbSet<Salesperson> Salesperson { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken ct);

        DbEntityEntry Entry(object entity);

        DbContextConfiguration Configuration { get; }
    }
}