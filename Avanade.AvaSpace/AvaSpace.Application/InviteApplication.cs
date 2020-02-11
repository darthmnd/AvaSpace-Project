using AvaSpace.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Applications;
using Gama.RedeSocial.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

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
