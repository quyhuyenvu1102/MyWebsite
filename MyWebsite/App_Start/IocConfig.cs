using Microsoft.Practices.Unity;
using MyWebsite.Infrastructure;
using MyWebsite.Models;
using MyWebsite.Repository.API;
using MyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWebsite.App_Start
{
    public class IocConfig
    {
        public static void UnityContainerConfig()
        {
            IUnityContainer container = new UnityContainer();
            RegisterServices(container);
            DependencyResolver.SetResolver(new UnityResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityAPIResolver(container);

        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterInstance<IBlogPostService>(new DefaultBlogPostService(new ApplicationDbContext()));
            container.RegisterInstance<ICommentService>(new DefaultCommentService(new ApplicationDbContext()));

            var context = new ApplicationDbContext();
            //API config
            container.RegisterInstance<ICustomerAPIService>(new DefaultCustomerService(context));
            container.RegisterInstance<IOrderApiService>(new DefaultOrderService(context));
            container.RegisterInstance<IOrderItemService>(new DefaultOrderItemService(context));
            container.RegisterInstance<IProductAPIService>(new DefaultProductService(context));
            container.RegisterInstance<ISalespersonService>(new DefaultSalespersonService(context));
        }
    }
}