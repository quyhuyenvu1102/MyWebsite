using Microsoft.Practices.Unity;
using MyWebsite.Infrastructure;
using MyWebsite.Repository.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace MyWebsite
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            

            // Web API routes
            config.MapHttpAttributeRoutes();

            
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.Routes.MapHttpRoute(
                name: "RootRoute",
                routeTemplate: "api/{controller}/{action}",
                defaults: new { controller = "Root", action = "Index" }
                );

            var json = config.Formatters.JsonFormatter;
            json.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;

        }

    }
}
