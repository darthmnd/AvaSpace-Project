using System;

namespace AvaSpace.Domain.Entities
{
    public class Invite : BaseEntity
    {
        public User Sender { get; set; }
        public User Receiver { get; set; }
        public InviteStatus Status { get; set; }

        public override void Validate()
        {
            if (Sender == null) throw new ArgumentNullException("O Remetente deve ser passado.");
            if (Receiver == null) throw new ArgumentNullException("O Destinatário deve ser passado.");
            if (Status == null) throw new ArgumentNullException("O Status da Solicitação deve ser passado.");
        }
    }
}
