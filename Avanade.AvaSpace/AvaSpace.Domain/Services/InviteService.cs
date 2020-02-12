using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Services
{
    public class InviteService : ServiceBase<Invite>, IInviteService
    {
        private readonly IInviteRepository _repository;
        private readonly IUserRepository _userRepository;

        public InviteService(IInviteRepository repository, IUserRepository userRepository) : base(repository)
        {
            _repository = repository;
            _userRepository = userRepository;
        }

        public IEnumerable<Invite> GetByUserId(Guid userId)
        {
            if (_userRepository.Get(userId).Active)
            {
                return _repository.GetByUserId(userId);
            }

            throw new SystemException("Usuário Inativo");
        }

        public IEnumerable<Invite> GetFriends(Guid userId)
        {
            if (_userRepository.Get(userId).Active)
            {
                return _repository.GetFriends(userId);
            }

            throw new SystemException("Usuário Inativo");
        }
    }
}

