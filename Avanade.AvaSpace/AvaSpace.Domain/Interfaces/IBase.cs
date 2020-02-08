using AvaSpace.Domain.Entities;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace AvaSpace.Domain.Interfaces
{
    public interface IBase<TEntity> where TEntity : BaseEntity
    {
        bool Insert(TEntity entity);
        IQueryable<TEntity> Get(Expression<Func<bool, TEntity>> predicate);
        TEntity Get(Guid id);
        bool Update(TEntity entity);
        bool Delete(Guid id);
    }
}
