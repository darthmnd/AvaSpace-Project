using AvaSpace.Domain.Entities.ValueObjects;
using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Event : BaseEntity
    {
        public Event(User author, string eventName, Address address, DateTime eventDate) 
        {
            Author = new User(author);
            Address = new Address(address);
            Author = author;
            Name = eventName;
            Address = address;
            EventDate = eventDate;
        }
        public Address Address { get; private set; }
        public DateTime EventDate { get; set; }
        public string Name { get; set; }
        public List<PersonEvent> Persons { get; set; }
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public override void Validate()
        {
            if (!Address.Valid) throw new ArgumentException("Endereço inválido.");
            if (Author.Id == Guid.Empty) throw new ArgumentException("O Usuário criador do evento é obrigatório");
            DateTime date = new DateTime();
            if (EventDate == date) throw new ArgumentException("O Usuário criador do evento é obrigatório");
        }
    }
}