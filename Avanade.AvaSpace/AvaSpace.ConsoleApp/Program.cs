using AvaSpace.Domain.Entities;
using System;

namespace AvaSpace.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("", "", DateTime.Now, "F");
            Console.WriteLine($"Name: {user.Name.FullName}");
            Console.WriteLine($"Valido? {user.Name.Valid}");
            Console.WriteLine($"Email: {user.Email.EmailAddress}");
            Console.WriteLine($"Valido?: {user.Email.Valid}");
            Console.WriteLine($"Data de Nasc.: {user.Birthday}");
            Console.WriteLine($"Genero: {user.Gender.Description}");

            Console.ReadLine();
        }
    }
}
