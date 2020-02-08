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
            Map(e => e.Gender.Id).ToColumn("ID_GENDER");
            Map(e => e.Cover.Path).ToColumn("ID_COVER");
            Map(e => e.Avatar.Path).ToColumn("ID_AVATAR");
        }
    }
}