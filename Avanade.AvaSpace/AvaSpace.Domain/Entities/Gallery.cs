using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public string Name { get; set; }
        public User Author { get; set; }
        public List<Midia> Midias { get; set; }
    }
}
