using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class UserMapper : BaseMapper<User>
    {
        public UserMapper()
        {
            ToTable("TB_USER");
            Map(e => e.Name.FullName).ToColumn("NM_USER");
            Map(e => e.Email.EmailAddress).ToColumn("DS_EMAIL");
            Map(e => e.Password).ToColumn("DS_PASSWORD");
            Map(e => e.Birthday).ToColumn("DT_BIRTHDAY");
            Map(e => e.GenderId).ToColumn("ID_GENDER");
            Map(e => e.CoverId).ToColumn("ID_COVER");
            Map(e => e.AvatarId).ToColumn("ID_AVATAR");
        }
    }
}