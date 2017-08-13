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
    public class DefaultCustomerService : ICustomerAPIService
    {
        private readonly IApiDbContext _context;

        public DefaultCustomerService() : this(new ApiDbContext()) { }

        public DefaultCustomerService(IApiDbContext context) {
            _context = context;
        }

        public async Task<int> Add(Customer customer, CancellationToken ct)
        {
            _context.Customers.Add(customer);
            return await _context.SaveChangesAsync(ct);
        }

        public async Task<Customer> Find(int key, CancellationToken ct)
        => await GetAll().Where(e => e.CustomerId == key).SingleOrDefaultAsync(ct);

        public IQueryable<Customer> GetAll()
        => _context.Customers.AsQueryable();

        public async Task<Customer> Remove(int key, CancellationToken ct)
        {
            var customer = GetAll().Where(e => e.CustomerId == key).SingleOrDefault();
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync(ct);
            return customer;
        }

        public async Task<int> Update(Customer customer, CancellationToken ct)
        {
            _context.Entry(customer).State = EntityState.Modified;
            return await _context.SaveChangesAsync(ct);
        }
    }
}