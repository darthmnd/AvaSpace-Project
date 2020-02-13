using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Repository.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AvaSpace.IoC.Containers
{
    public class RepositoryContainer : BaseContainer
    {
        public RepositoryContainer(IServiceCollection services) : base(services)
        {
            services.AddSingleton<IGalleryRepository, GalleryRepository>();
            services.AddSingleton<IGenderRepository, GenderRepository>();
            services.AddSingleton<IInviteRepository, InviteRepository>();
            services.AddSingleton<IInviteStatusRepository, InviteStatusRepository>();
            services.AddSingleton<ILikeRepository, LikeRepository>();
            services.AddSingleton<IMidiaRepository, MidiaRepository>();
            services.AddSingleton<IMidiaTypeRepository, MidiaTypeRepository>();
            services.AddSingleton<IPostRepository, PostRepository>();
            services.AddSingleton<IUserRepository, UserRepository>();
        }
    }
}
