using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace MyWebsite.Repository.API
{
    public interface ICustomerAPIService
    {
        IQueryable<Customer> GetAll();

        //Add find remove update

        Task<int> Add(Customer customer, CancellationToken ct);

        Task<Customer> Find(int key, CancellationToken ct);

        Task<Customer> Remove(int key, CancellationToken ct);

        Task<int> Update(Customer customer, CancellationToken ct);

    }
}