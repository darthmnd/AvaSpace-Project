using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace AvaSpace.Application
{
    public class InviteApplication : ApplicationBase<Invite>, IInviteApplication
    {
        private readonly IInviteService _service;

        public InviteApplication(IInviteService Service) : base(Service)
        {
            _service = Service;
        }

        public IEnumerable<Invite> GetByUserId(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
