using System;

namespace AvaSpace.Domain.Entities
{
    public class Midia : BaseEntity
    {
        public Midia()
        {
            MidiaType = new MidiaType();
        }
        public Guid MidiaTypeId { get; set; }
        public MidiaType MidiaType { get; set; }
        public string Path { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrWhiteSpace(Path)) throw new ArgumentException("O Caminho da imagem deve ser passado.");
            if (MidiaType == null) throw new ArgumentException("O tipo da Midia deve ser passado.");
        }
    }
}
