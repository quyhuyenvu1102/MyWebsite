using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyWebsite.Models.API;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web.Http;
using System.Threading;

namespace MyWebsite.Services.API
{
    public class DefaultProductService : IProductAPIService
    {
        public IApiDbContext _context;

        public DefaultProductService() : this(new ApiDbContext()) { }

        public DefaultProductService(IApiDbContext context) {
            _context = context;
        }

        public async Task<int> Add(Product product, CancellationToken ct)
        {
            _context.Products.Add(product);
            return await _context.SaveChangesAsync(ct);
        }

        public async Task<Product> Find(string key, CancellationToken ct)
        {
            return await GetAll().Where(e => e.ProductId == key).SingleOrDefaultAsync();
        }

        public IQueryable<Product> GetAll()
        {
            return _context.Products.AsQueryable();
        }

        public async Task<Product> Remove(string key, CancellationToken ct)
        {

            var product = await Find(key, ct);
            _context.Products.Remove(product);
            await _context.SaveChangesAsync(ct);
            return product;
        }

        public async Task<int> Update(Product item,CancellationToken ct)
        {
            _context.Entry(item).State = EntityState.Modified;
            return await _context.SaveChangesAsync(ct);
        }
    }
}