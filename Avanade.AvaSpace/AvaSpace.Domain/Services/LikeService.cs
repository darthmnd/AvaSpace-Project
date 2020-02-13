using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class LikeService : ServiceBase<Like>, ILikeService
    {
        private readonly ILikeRepository _repository;

        public LikeService(ILikeRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
