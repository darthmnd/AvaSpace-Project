using AvaSpace.Domain.Entities;

namespace AvaSpace.Domain.Interfaces.Applications
{
    public interface IApplicationBase<TEntity> : IBase<TEntity> where TEntity : BaseEntity
    {

    }
}
