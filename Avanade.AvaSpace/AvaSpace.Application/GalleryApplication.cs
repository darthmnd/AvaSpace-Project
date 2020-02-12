using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Interfaces.Applications;

namespace AvaSpace.Application
{
    public class GalleryApplication : ApplicationBase<Gallery>, IGalleryApplication
    {
        private readonly IGalleryService _service;

        public GalleryApplication(IGalleryService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
