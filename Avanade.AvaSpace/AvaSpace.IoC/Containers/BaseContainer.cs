using Microsoft.Extensions.DependencyInjection;

namespace AvaSpace.IoC.Containers
{
    public class BaseContainer
    {
        private IServiceCollection _services;

        public BaseContainer(IServiceCollection services)
        {
            _services = services;
        }
    }
}
