using AvaSpace.Domain.Entities;
using Dapper.FluentMap.Dommel.Mapping;

namespace AvaSpace.Repository.Mappers
{
    public class BaseMapper<TEntity> : DommelEntityMap<TEntity> where TEntity : BaseEntity
    {
        public BaseMapper()
        {
            Map(e => e.Id).ToColumn("ID").IsKey();
            Map(e => e.DateCreate).ToColumn("DT_CREATED");
            Map(e => e.DateUpdate).ToColumn("DT_UPDATED");
            Map(e => e.Active).ToColumn("ST_ACTIVE");
        }
    }
}
