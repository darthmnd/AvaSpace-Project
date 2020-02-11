using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class MidiaService : ServiceBase<Midia>, IMidiaService
    {

        private readonly IMidiaRepository _midiaRepository;
        public MidiaService(IMidiaRepository midiaRepository) : base(midiaRepository)
        {
            _midiaRepository = midiaRepository;
        }

    }
}
