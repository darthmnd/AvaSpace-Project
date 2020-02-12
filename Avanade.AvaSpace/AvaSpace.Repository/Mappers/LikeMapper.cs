using AvaSpace.Domain.Entities;
namespace AvaSpace.Repository.Mappers
{
    public class LikeMapper : BaseMapper<Like>
    {
        public LikeMapper()
        {
            ToTable("TB_LIKES");
            Map(e => e.UserId).ToColumn("ID_USER");
            Map(e => e.PostId).ToColumn("ID_POST");
        }
    }
}
