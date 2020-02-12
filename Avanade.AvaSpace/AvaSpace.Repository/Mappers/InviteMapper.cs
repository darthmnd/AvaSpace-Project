using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class InviteMapper : BaseMapper<Invite>
    {
        public InviteMapper()
        {
            ToTable("TB_INVITE");
            Map(e => e.SenderId).ToColumn("ID_SENDER");
            Map(e => e.ReceiverId).ToColumn("ID_RECEIVER");
            Map(e => e.InviteStatusId).ToColumn("ID_STATUS");
        }
    }
}
