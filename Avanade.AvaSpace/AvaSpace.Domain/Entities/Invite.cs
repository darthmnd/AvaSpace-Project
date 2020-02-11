using System;

namespace AvaSpace.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public Invite()
        {
            Active = true;
        }
        public Guid SenderId { get; set; }
        public User Sender { get; set; }
        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }
        public Guid StatusId { get; set; }
        public InviteStatus Status { get; set; }
        public Guid ReceiverId { get; set; }
        public Guid SenderId { get; set; }

        public override void Validate()
        {
            if (Sender == null) throw new ArgumentNullException("O Remetente deve ser passado.");
            if (Receiver == null) throw new ArgumentNullException("O Destinatário deve ser passado.");
            if (Status == null) throw new ArgumentNullException("O Status da Solicitação deve ser passado.");
        }
    }
}
