using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Applications
{
    public interface IPostApplication : IApplicationBase<Post>
    {
        IEnumerable<Post> GetFeedByUserId(Guid userId);
    }
}
