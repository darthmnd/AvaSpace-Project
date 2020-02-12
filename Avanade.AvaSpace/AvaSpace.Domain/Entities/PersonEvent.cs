using System;

namespace AvaSpace.Domain.Entities
{
    public class PersonEvent : BaseEntity
    {
        public Guid EventId { get; set; }
        public Event Event { get; set; }
        public Guid PersonId { get; set; }
        public User Person { get; set; }
        public override void Validate()
        {
            if (EventId == Guid.Empty)
                throw new ArgumentException("O Id do evento é obrigatório.");
            if (PersonId == Guid.Empty)
                throw new ArgumentException("O Id do evento é obrigatório.");
        }
    }
}