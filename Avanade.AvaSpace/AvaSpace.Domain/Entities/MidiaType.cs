using System;

namespace AvaSpace.Domain.Entities
{
   public class MidiaType : BaseEntity
   {
        public string Description { get; set; }
        public string Extensions { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Extensions)) throw new ArgumentException("É necessário passar a extensão do arquivo.");
        }
    }
}
