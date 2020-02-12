using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Application
{
    public class LikeApplication : ApplicationBase<Like>, ILikeApplication
    {
        private readonly ILikeService _service;

        public LikeApplication(ILikeService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
