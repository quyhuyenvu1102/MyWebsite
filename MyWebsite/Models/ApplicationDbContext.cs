using Microsoft.AspNet.Identity.EntityFramework;
using MyWebsite.Models.API;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyWebsite.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public IDbSet<BlogPostEntity> BlogPosts { get; set; }

        public IDbSet<CommentEntity> Comments { get; set; }

        public IDbSet<MovieEntity> Movies { get; set; }

        //------------------------------------
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Order> Orders { get; set; }
        public IDbSet<OrderItem> OrderItems { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Salesperson> Salesperson { get; set; }
    }
}