using System;

namespace AvaSpace.Domain.Entities
{
    public class Gender : BaseEntity
    {
        public Gender() { }
        public Gender(string description) 
        {
            Description = description;
        }
        public string Description { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Description))
                throw new ArgumentNullException("'Description' não foi preenchido");
        }
    }
}
