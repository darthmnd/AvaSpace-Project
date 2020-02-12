using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace AvaSpace.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity>
        where TEntity : BaseEntity
    {
        
        private readonly IRepositoryBase<TEntity> _repositoryBase;
        
        /// isto é uma injeção de dependência, ou seja, para ServiceBase ser utilizada é
        /// necessário passar um objeto que implemente IRepositoryBase.
        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public bool Delete(Guid id)
        {
            if (id == new Guid()) throw new ArgumentNullException("O Id deve ser preenchido.");
            return _repositoryBase.Delete(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return _repositoryBase.Get();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return _repositoryBase.Get(predicate);
        }

        public TEntity Get(Guid id)
        {
            return _repositoryBase.Get(id);
        }

        public Guid Insert(TEntity entity)
        {
            entity.Validate();
            return _repositoryBase.Insert(entity);
        }

        public bool Update(TEntity entity)
        {
            entity.Validate();
            return _repositoryBase.Update(entity);
        }
    }
}
