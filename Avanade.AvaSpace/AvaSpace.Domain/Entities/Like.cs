using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Entities
{
    public class Like : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; }
        public Guid PostId { get; set; }
        public Post Post { get; set; }

        public override void Validate()
        {
            if (User == null) throw new ApplicationException("O Usuário é obrigatório.");
            if (Post == null) throw new ApplicationException("O Post é obrigatório.");
        }
    }
}
