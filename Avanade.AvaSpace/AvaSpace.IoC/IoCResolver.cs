using AvaSpace.IoC.Containers;
using AvaSpace.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.IoC
{
    public class IoCResolver
    {
        private static IServiceCollection _services;
        private static IServiceProvider _provider;

        public static void RegisterContainers(IServiceCollection services, IServiceProvider provider)
        {
            _services = services;
            _provider = provider;

            new RepositoryContainer(_services);
            new ServiceContainer(_services);
            new ApplicationContainer(_services);

            RegisterMappers.Register();
        }
        public static T Resolve<T>()
        {
            return _provider.GetService<T>();
        }
    }
}
