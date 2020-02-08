using AvaSpace.Domain.Entities;

namespace AvaSpace.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {
    }
}
