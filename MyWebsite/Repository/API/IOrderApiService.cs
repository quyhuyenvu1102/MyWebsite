using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Repository.API
{
    public interface IOrderApiService
    {
        Task<int> Add(Order order, CancellationToken ct);

        Task<int> Update(Order order, CancellationToken ct);

        Task<Order> Find(int id, CancellationToken ct);

        Task<Order> Remove(int id, CancellationToken ct);

        IQueryable<Order> GetAll();
    }
}