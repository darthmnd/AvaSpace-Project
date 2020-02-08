using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using System.Collections.Generic;

namespace AvaSpace.Repository.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public IEnumerable<User> Get(string name)
        {
            var sql = "SELECT * FROM TB_USER WHERE NM_USER = @name";
            var parameters = new { 
                 name
            };
            return Execute<User>(sql, parameters);
        }
    }
}
