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
    public class DefaultOrderItemService : IOrderItemService
    {
        public readonly IApiDbContext _context;

        public DefaultOrderItemService():this(new ApiDbContext()) { }

        public DefaultOrderItemService(IApiDbContext context) {
            _context = context;
        }

        public async Task<int> Add(OrderItem item, CancellationToken ct)
        {
            _context.OrderItems.Add(item);
            return await _context.SaveChangesAsync(ct);
        }

        public async Task<OrderItem> Find(int id, CancellationToken ct)
        => await GetAll().Where(e => e.OrderItemId == id).SingleOrDefaultAsync(ct);

        public IQueryable<OrderItem> GetAll()
        => _context.OrderItems.AsQueryable();

        public async Task<OrderItem> Remove(int id, CancellationToken ct)
        {
            var item = GetAll().Where(e => e.OrderItemId == id).Single();
            _context.OrderItems.Remove(item);

            await _context.SaveChangesAsync(ct);

            return item;
        }

        public async Task<int> Update(OrderItem item, CancellationToken ct)
        {
            _context.Entry(item).State = EntityState.Modified;

            return await _context.SaveChangesAsync(ct);
        }
    }
}