using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Repository.API
{
    public interface IOrderItemService
    {
        Task<int> Add(OrderItem item, CancellationToken ct);

        Task<int> Update(OrderItem item, CancellationToken ct);

        Task<OrderItem> Remove(int id, CancellationToken ct);

        Task<OrderItem> Find(int id, CancellationToken ct);

        IQueryable<OrderItem> GetAll();
    }
}