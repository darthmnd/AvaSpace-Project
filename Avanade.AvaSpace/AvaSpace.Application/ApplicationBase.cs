using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace AvaSpace.Application
{
    public class ApplicationBase<TEntity> : IApplicationBase<TEntity> 
        where TEntity : BaseEntity
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public ApplicationBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;       
        }
        public bool Delete(Guid id)
        {
            return _serviceBase.Delete(id);
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _serviceBase.Get(predicate);
        }

        public TEntity Get(Guid id)
        {
            return _serviceBase.Get(id);
        }

        public Guid Insert(TEntity entity)
        {
            return _serviceBase.Insert(entity);
        }

        public bool Update(TEntity entity)
        {
            return _serviceBase.Update(entity);
        }
    }
}
