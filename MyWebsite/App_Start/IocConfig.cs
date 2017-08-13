using Microsoft.Practices.Unity;
using MyWebsite.Infrastructure;
using MyWebsite.Models;
using MyWebsite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        }

        private static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IBlogPostService, DefaultBlogPostService>(new InjectionConstructor(new ApplicationDbContext()));
            container.RegisterType<ICommentService, DefaultCommentService>(new InjectionConstructor(new ApplicationDbContext()));
        }
    }
}