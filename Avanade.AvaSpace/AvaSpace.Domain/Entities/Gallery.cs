using AvaSpace.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public Gallery()
        {
            User = new User();
            Midias = new List<Midia>();
        }

        public Name Name { get; private set; }
        public List<Midia> Midias { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrEmpty(Name))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if (UserId == Guid.Empty)
                throw new ArgumentNullException("'AuthorId' não foi preenchido");

        }
    }
}
