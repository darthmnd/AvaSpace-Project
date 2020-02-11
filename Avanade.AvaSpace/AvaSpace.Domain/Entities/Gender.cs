using System;

namespace AvaSpace.Domain.Entities
{
    public class Gender : BaseEntity
    {
        public Gender()
        {
        }

        public Gender(string description) 
        {
            Description = description;
        }
        public string Description { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Description)) throw new ArgumentNullException("O Gênero deve ser preenchido.");
        }
    }
}
