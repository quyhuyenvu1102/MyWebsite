using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using MyWebsite.Models.API;
using System.Data.Entity;

namespace MyWebsite.Repository.API
{
    public class DefaultOrderService : IOrderApiService
    {
        private readonly IApiDbContext _context;

        public DefaultOrderService() : this(new ApiDbContext()) { }

        public DefaultOrderService(IApiDbContext context) {
            _context = context;
            //_context.Configuration.ProxyCreationEnabled = false;
        }
        public async Task<int> Add(Order order, CancellationToken ct)
        {
            _context.Orders.Add(order);
            return await _context.SaveChangesAsync(ct);
        }

        public IQueryable<Order> GetAll()
            => _context.Orders.AsQueryable();

        public async Task<Order> Find(int id, CancellationToken ct)
            => await GetAll().Where(e => e.OrderId == id).SingleOrDefaultAsync(ct);
        

        public async Task<Order> Remove(int id, CancellationToken ct)
        {
            var order = GetAll().Where(e => e.OrderId == id).Single();
            _context.Orders.Remove(order);

            await _context.SaveChangesAsync(ct);
            return order;   
        }

        public Task<int> Update(Order order, CancellationToken ct)
        {
            throw new NotImplementedException();
        }
    }
}