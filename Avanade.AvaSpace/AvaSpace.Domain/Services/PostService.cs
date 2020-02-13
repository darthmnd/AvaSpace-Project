using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Services
{
    public class PostService : ServiceBase<Post>, IPostService
    {
        private readonly IPostRepository _repository;

        public PostService(IPostRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<Post> GetFeedByUserId(Guid userId)
        {
            return _repository.GetFeedByUserId(userId);
        }

    }
}
