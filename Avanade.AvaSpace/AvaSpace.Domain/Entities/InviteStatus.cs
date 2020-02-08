using System;

namespace AvaSpace.Domain.Entities
{
    public class InviteStatus : BaseEntity
    {
        public string Description { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentException("A Descrição do Status deve ser passada.");
        }
    }
}