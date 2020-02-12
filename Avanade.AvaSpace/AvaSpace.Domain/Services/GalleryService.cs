using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;

namespace AvaSpace.Domain.Services
{
    public class GalleryService : ServiceBase<Gallery>, IGalleryService
    {
        private readonly IGalleryRepository _repository;

        public GalleryService(IGalleryRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Gallery GetFeedByUserId(Guid userId)
        {
            return _repository.GetFeedByUserId(userId);
        }
    }
}
