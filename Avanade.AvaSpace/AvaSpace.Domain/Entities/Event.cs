using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AvaSpace.Domain.Entities
{
    public class Event : BaseEntity
    {
        public Event()
        {
            Author = new User();
        }
        public DateTime EventDate { get; set; }
        public string Name { get; set; }
        public List<PersonEvent> Persons { get; set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public string ZipCode { get; set; }

        public string Street { get; set; }

        public int Number { get; set; }

        public string Neighborhood { get; set; }

        public string Complement { get; set; }
        public override void Validate()
        {
            if (Author.Id == Guid.Empty) throw new ArgumentException("O Usuário criador do evento é obrigatório");
            if (EventDate == DateTime.MinValue) throw new ArgumentException("A data do evento deve ser válida.");
            if (!Regex.IsMatch(ZipCode ?? string.Empty, @"^\d{5}-\d{3}$")) throw new ArgumentException("CEP inválido.");
        }
    }
}