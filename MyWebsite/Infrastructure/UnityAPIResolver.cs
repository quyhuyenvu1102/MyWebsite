using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace MyWebsite.Infrastructure
{
    public class UnityAPIResolver : IDependencyResolver
    {
        public readonly IUnityContainer _container;

        public UnityAPIResolver(IUnityContainer container)
        {
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        public IDependencyScope BeginScope()
        {
            var child = _container.CreateChildContainer();
            return new UnityAPIResolver(child);
        }

        public void Dispose()
        {
            Dispose(true);
        }

        public virtual void Dispose(bool disposing)
        {
            _container.Dispose();
        }

        public object GetService(Type serviceType)
        {
            try
            {
                return _container.Resolve(serviceType);
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            try
            {
                return _container.ResolveAll(serviceType);
            }
            catch
            {
                return new List<object>();
            }
        }
    }
}