using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class InviteStatusService : ServiceBase<InviteStatus>, IInviteStatusService
    {
        private readonly IInviteStatusRepository _repository;

        public InviteStatusService(IInviteStatusRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
