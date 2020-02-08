using AvaSpace.Domain.Entities.ValueObjects;
using System;

namespace AvaSpace.Domain.Entities
{
    public class User : BaseEntity
    {
        public User (string fullName, string emailAddress, DateTime birthDate, string gender)
        {
            Name = new Name(fullName);
            Email = new Email(emailAddress);
            Birthday = birthDate;
            Gender = new Gender();
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public Midia Cover { get; set; }
        public Midia Avatar { get; set; }

        public override void Validate()
        {
            if (!Name.Valid) throw new ArgumentException("O Nome está inválido.");
            if (!Email.Valid) throw new ArgumentException("O Email está inválido.");
        }
    }
}
