using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Applications
{
    public interface IInviteApplication : IApplicationBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
    }
}

