using AvaSpace.Domain.Entities;
using System.Collections.Generic;

namespace AvaSpace.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
        void Execute(string sql, object parameters);
        IEnumerable<T> Execute<T>(string sql, object parameters);
    }
}
