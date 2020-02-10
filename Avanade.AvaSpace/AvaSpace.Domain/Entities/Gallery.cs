using AvaSpace.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public Gallery(string name)
        {
            Name = new Name(name);
        }
        public Name Name { get; private set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public List<Midia> Midias { get; set; }

        public override void Validate()
        {
            if (Author == null) throw new ArgumentNullException("O Autor deve ser preenchido.");
            if (Name == null) throw new ArgumentNullException("O Nome deve ser preenchido.");
        }
    }
}
