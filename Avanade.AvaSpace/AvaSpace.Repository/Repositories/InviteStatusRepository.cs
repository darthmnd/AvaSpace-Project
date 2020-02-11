using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Repository;
using System;
using System.Collections.Generic;

public class InviteStatusRepository : RepositoryBase<InviteStatus>, IInviteStatusRepository
{
    public IEnumerable<Invite> GetByUserId(Guid userId)
    {
        throw new NotImplementedException();
    }
}
