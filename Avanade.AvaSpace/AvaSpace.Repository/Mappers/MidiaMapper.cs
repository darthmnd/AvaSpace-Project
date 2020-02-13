using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class MidiaMapper : BaseMapper<Midia>
    {
        public MidiaMapper()
        {
            ToTable("TB_MIDIA");
            Map(e => e.Description).ToColumn("DS_MIDIA");
            Map(e => e.MidiaTypeId).ToColumn("ID_MIDIA_TYPE");
            Map(e => e.Path).ToColumn("DS_FILE_PATH");
        }
    }
}
