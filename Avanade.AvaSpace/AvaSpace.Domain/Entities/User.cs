using System;
using System.Text.RegularExpressions;

namespace AvaSpace.Domain.Entities
{
    public class User : BaseEntity
    {
        public User() 
        {
            Gender = new Gender();
            Avatar = new Midia();
            Cover = new Midia();
        }
        
        public string Name { get; set; }
        public string Email { get; set; }
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
            if (string.IsNullOrWhiteSpace(Name)) 
                throw new ArgumentNullException("O Nome está inválido.");

            if (string.IsNullOrWhiteSpace(Email))
                throw new ArgumentNullException("O Email está inválido.");

            if (!Regex.IsMatch(Email ?? string.Empty, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"))
                throw new ArgumentException("O Email está inválido.");
            
            if (string.IsNullOrWhiteSpace(Password))
                throw new ArgumentNullException("Senha não foi preenchido");

            if (Password.Length < 8)
                throw new ArgumentException("Senha não pode ser menor que 8 caracteres");

            if (Birthday == null)
                throw new ArgumentNullException("Data de Nascimento não foi preenchido");

            if (Birthday == DateTime.MinValue)
                throw new ArgumentException("Data de Nascimento é inválido");

            if (GenderId == Guid.Empty)
                throw new ArgumentNullException("O gênero é obrigatório");
        }
    }
}
