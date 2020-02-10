using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Entities.ValueObjects;
using System;

namespace AvaSpace.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User author = new User("nathaliaspinula", "nat@gmail.com", DateTime.Now, "Female");
            Address address = new Address("02732-020", "rua antonio de couros", 1, "AAA");
            Event e = new Event(author, "Evento!", address, DateTime.Now);
            Console.WriteLine(e.Address.Valid);
            Console.WriteLine(e.Address.ZipCode);
            Console.WriteLine(e.Address.Street);
            Console.WriteLine(e.Address.Number);
            Console.WriteLine(e.Address.Neighborhood);
            Console.WriteLine(e.Author.Name.FullName);
            Console.WriteLine(e.Author.Gender.Description);
            Console.WriteLine(e.Author.Birthday);
            Console.WriteLine(e.Name);
            Console.WriteLine(e.EventDate);

            Console.ReadLine();
        }
    }
}
