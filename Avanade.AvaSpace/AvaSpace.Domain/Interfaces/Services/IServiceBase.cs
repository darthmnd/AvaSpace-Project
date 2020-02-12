using AvaSpace.Domain.Entities;

namespace AvaSpace.Domain.Interfaces.Services
{
    public interface IServiceBase<TEntity> : IBase<TEntity> 
        where TEntity : BaseEntity
    {
    }
}
