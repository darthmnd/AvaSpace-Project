using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Application
{
    public class PostApplication : ApplicationBase<Post>, IPostApplication
    {
        private readonly IPostService _service;

        public PostApplication(IPostService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
