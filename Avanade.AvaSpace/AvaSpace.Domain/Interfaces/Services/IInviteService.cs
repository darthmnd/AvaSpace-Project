using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Services
{
    public interface IInviteService : IServiceBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
        IEnumerable<Invite> GetFriends(Guid userId);
    }
}
