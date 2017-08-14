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
    public class DefaultSalespersonService : ISalespersonService
    {
        public readonly IApiDbContext _context;

        public DefaultSalespersonService():this(new ApiDbContext()) { }

        public DefaultSalespersonService(IApiDbContext context) {
            _context = context;
        }

        public int Add(Salesperson person)
        {
            _context.Salesperson.Add(person);
            return _context.SaveChanges();
        }

        public async Task<int> Add(Salesperson person, CancellationToken ct)
        {
            _context.Salesperson.Add(person);
            return await _context.SaveChangesAsync(ct);
        }

        public async Task<Salesperson> Find(int id, CancellationToken ct)
        => await GetAll().Where(e => e.SalespersonId == id).SingleOrDefaultAsync(ct);

        public IQueryable<Salesperson> GetAll()
            => _context.Salesperson.AsQueryable();

        public async Task<Salesperson> Remove(int id, CancellationToken ct)
        {
            var person = GetAll().Where(e => e.SalespersonId == id).SingleOrDefault();

            _context.Salesperson.Remove(person);
            await _context.SaveChangesAsync(ct);

            return person;
        }

        public Task<int> Update(Salesperson person, CancellationToken ct)
        {
            _context.Entry(person).State = EntityState.Modified;

            return _context.SaveChangesAsync(ct);
        }
    }
}