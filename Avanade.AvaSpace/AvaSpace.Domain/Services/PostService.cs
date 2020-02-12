using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class PostService : ServiceBase<Post>, IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository) : base(repository)
        {
            _repository = repository;
        }

    }
}
