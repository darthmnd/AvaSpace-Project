
using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Services
{
    public interface IPostService : IServiceBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
