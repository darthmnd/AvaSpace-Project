using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Application
{
    public class InviteStatusApplication : ApplicationBase<InviteStatus>, IIviteStatusApplication
    {
        private readonly IInviteStatusService _service;

        public InviteStatusApplication(IInviteStatusService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
