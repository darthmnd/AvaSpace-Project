using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AvaSpace.Domain.Interfaces
{
    public interface IBase<TEntity> where TEntity : BaseEntity
    {
        Guid Insert(TEntity entity);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Guid id);
        bool Update(TEntity entity);
        bool Delete(Guid id);
    }
}
