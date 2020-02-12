using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public Gallery() {
            Author = new User();
            Midias = new List<Midia>();
        }
        public Gallery(string name)
        {
            Name = name;
        }
        public string Name { get; private set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public List<Midia> Midias { get; set; }

        public override void Validate()
        {
            if (Author == null) throw new ArgumentNullException("O Autor deve ser preenchido.");
            if (string.IsNullOrWhiteSpace(Name)) throw new ArgumentNullException("O Nome deve ser preenchido.");
        }
    }
}
