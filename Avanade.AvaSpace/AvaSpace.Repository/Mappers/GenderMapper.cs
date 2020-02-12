using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class GenderMapper : BaseMapper<Gender>
    {
        public GenderMapper() 
        {
            ToTable("TB_GENDER");
            Map(entity => entity.Description).ToColumn("DS_GENDER");
        }
    }
}
