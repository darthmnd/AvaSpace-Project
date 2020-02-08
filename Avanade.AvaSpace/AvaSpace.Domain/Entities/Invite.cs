namespace AvaSpace.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public InviteStatus InviteStatus { get; set; }
    }
}
