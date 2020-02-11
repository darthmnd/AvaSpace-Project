using AvaSpace.Domain.Entities.ValueObjects;
using System;

namespace AvaSpace.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            Gender = new Gender();
            Cover = new Midia();
            Avatar = new Midia();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public Guid GenderId { get; set; }
        public Gender Gender { get; set; }
        public Guid CoverId { get; set; }
        public Midia Cover { get; set; }
        public Guid AvatarId { get; set; }
        public Midia Avatar { get; set; }

        public override void Validate()
        {
            if (!Name.Valid) 
                throw new ArgumentException("O Nome está inválido.");
            if (!Email.Valid) 
                throw new ArgumentException("O Email está inválido.");
            
            if (String.IsNullOrWhiteSpace(Password))
                throw new ArgumentNullException("Senha não foi preenchido");

            if (Password.Length < 8)
                throw new ArgumentException("Senha não pode ser menor que 8 caracteres");

            if (Birthday == null)
                throw new ArgumentNullException("Data de Nascimento não foi preenchido");

            if (Birthday == DateTime.MinValue)
                throw new ArgumentException("Data de Nascimento é inválido");
        }
    }
}
