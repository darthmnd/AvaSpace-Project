using Gama.RedeSocial.Domain.Entities;
using Gama.RedeSocial.Domain.Interfaces.Repositories;
using System;

namespace Gama.RedeSocial.Infrastructure.Persistence.Repository.Repositories
{
    public class PostRespository : RepositoryBase<Post>, IPostRepository
    {
        public override Post Get(Guid id)
        {
            
        }
    }
}
