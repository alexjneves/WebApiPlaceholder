using System.Web.Http;
using Microsoft.Practices.Unity;
using Placeholder.Storage;
using Placeholder.Storage.InMemory;
using Unity.WebApi;

namespace Placeholder.API
{
    public static class StorageConfig
    {
        public static void Initialize(HttpConfiguration config)
        {
            var container = new UnityContainer();
            container.RegisterInstance<IPlaceholderStorage>(new InMemoryPlaceholderStorage());

            config.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}