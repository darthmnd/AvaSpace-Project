using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Interfaces.Applications;

namespace AvaSpace.Application
{
    public class GalleryApplication : ApplicationBase<Gallery>, IGalleryApplication
    {
        private readonly IGalleryService _service;
        private readonly IUserService _userService;

        public GalleryApplication(IGalleryService service, IUserService userService) : base(service)
        {
            _service = service;
            _userService = userService;
        }
    }
}
