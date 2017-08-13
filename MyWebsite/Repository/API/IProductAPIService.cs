using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Repository.API
{
    public interface IProductAPIService
    {
        Task<int> Add(Product product,CancellationToken ct);

        IQueryable<Product> GetAll();

        Task<Product> Find(string key, CancellationToken ct);

        Task<Product> Remove(string key, CancellationToken ct);

        Task<int> Update(Product item,CancellationToken ct);
    }
}