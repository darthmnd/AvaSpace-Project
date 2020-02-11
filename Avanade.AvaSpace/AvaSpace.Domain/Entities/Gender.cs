using System;

namespace AvaSpace.Domain.Entities
{
    public class Gender : BaseEntity
    {
        private string v;

        public Gender(string v)
        {
            this.v = v;
        }

        public string Description { get; set; }

        public override void Validate()
        {
            if (String.IsNullOrWhiteSpace(Description))
                throw new ArgumentNullException("Description' não foi preenchido");
        }
    }
}
