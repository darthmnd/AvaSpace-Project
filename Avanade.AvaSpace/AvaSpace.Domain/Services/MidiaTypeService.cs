using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class MidiaTypeService : ServiceBase<MidiaType>, IMidiaTypeService
    {
        private readonly IMidiaTypeRepository _repository;

        public MidiaTypeService(IMidiaTypeRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
