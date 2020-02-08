using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class MidiaTypeMapper : BaseMapper<MidiaType>
    {
        public MidiaTypeMapper()
        {
            ToTable("TB_MIDIA_TYPE");
            Map(e => e.Description).ToColumn("DS_MIDIA");
            Map(e => e.Extensions).ToColumn("DS_EXTENSIONS");
        }
    }
}
