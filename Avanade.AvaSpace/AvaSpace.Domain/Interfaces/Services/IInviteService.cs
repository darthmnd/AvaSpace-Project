using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Services
{
    public interface IInviteService : IServiceBase<Invite>
    
        {
        IEnumerable<Invite> GetByUserId(Guid userId);

    }
}
