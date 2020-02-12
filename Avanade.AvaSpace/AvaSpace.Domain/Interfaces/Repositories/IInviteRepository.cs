using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Repositories
{
    public interface IInviteRepository : IRepositoryBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
        IEnumerable<Invite> GetFriends(Guid userId);
    }
}
