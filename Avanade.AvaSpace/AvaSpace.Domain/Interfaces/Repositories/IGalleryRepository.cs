using AvaSpace.Domain.Entities;
using System;

namespace AvaSpace.Domain.Interfaces.Repositories
{
    public interface IGalleryRepository : IRepositoryBase<Gallery>
    {
        Gallery GetFeedByUserId(Guid userId);
    }
}
