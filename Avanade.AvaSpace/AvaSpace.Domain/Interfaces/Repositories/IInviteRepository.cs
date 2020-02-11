using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Interfaces.Repositories
{
    public interface IInviteRepository : IRepositoryBase<Invite>
    {
        IEnumerable<Invite> GetByUserId(Guid userId);
    }
}
