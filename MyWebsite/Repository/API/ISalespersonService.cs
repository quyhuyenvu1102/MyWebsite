using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Repository.API
{
    public interface ISalespersonService
    {
        Task<int> Add(Salesperson person,CancellationToken ct);

        int Add(Salesperson person);

        Task<int> Update(Salesperson person, CancellationToken ct);

        Task<Salesperson> Find(int id, CancellationToken ct);

        Task<Salesperson> Remove(int id, CancellationToken ct);

        IQueryable<Salesperson> GetAll();

    }
}