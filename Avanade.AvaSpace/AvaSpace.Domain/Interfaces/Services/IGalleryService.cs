using AvaSpace.Domain.Entities;
using System;

namespace AvaSpace.Domain.Interfaces.Services
{
    public interface IGalleryService : IServiceBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}
