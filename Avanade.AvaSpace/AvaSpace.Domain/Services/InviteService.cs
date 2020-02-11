using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Services;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace Gama.RedeSocial.Domain.Services
{
    public class InviteService : ServiceBase<Invite>, IInviteService
    {
        private readonly IInviteRepository _repository;

        public InviteService(IInviteRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Invite> GetByUserId(Guid userId)
        {
            return _repository.GetByUserId(userId);
        }
    }
}

