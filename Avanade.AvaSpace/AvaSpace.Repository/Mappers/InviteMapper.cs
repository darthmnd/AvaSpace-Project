using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class InviteMapper : BaseMapper<Invite>
    {
        public InviteMapper()
        {
            ToTable("TB_INVITE");
            Map(e => e.Sender.Id).ToColumn("ID_SENDER");
            Map(e => e.Receiver.Id).ToColumn("ID_RECEIVER");
            Map(e => e.Status.Id).ToColumn("ID_STATUS");
        }
    }
}
