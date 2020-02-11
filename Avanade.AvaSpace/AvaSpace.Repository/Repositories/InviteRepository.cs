using AvaSpace.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;

namespace AvaSpace.Repository.Repositories
{
    public class InviteRepository : RepositoryBase<Invite>, IInviteRepository
    {
        public IEnumerable<Invite> GetByUserId(Guid userId)
        {
            return Get(entity => entity.SenderId == userId || entity.ReceiverId == userId);
        }
    }
}
