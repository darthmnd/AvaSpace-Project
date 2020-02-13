using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace AvaSpace.Application
{
    public class PostApplication : ApplicationBase<Post>, IPostApplication
    {
        private readonly IPostService _service;

        public PostApplication(IPostService Service) : base(Service)
        {
            _service = Service;
        }

        public IEnumerable<Post> GetFeedByUserId(Guid userId)
        {
            return _service.GetFeedByUserId(userId);
        }
    }
}
