using AvaSpace.Domain.Entities;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        IEnumerable<User> Get(string name);
    }
}
