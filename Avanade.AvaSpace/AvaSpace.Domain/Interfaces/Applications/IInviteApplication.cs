using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Applications
{
    public interface IInviteApplication : IApplicationBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
    }
}
