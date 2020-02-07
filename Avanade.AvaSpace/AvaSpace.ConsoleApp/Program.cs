using AvaSpace.Domain.Entities;
using AvaSpace.Domain.ValueObjects;
using System;

namespace AvaSpace.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {           
            var birthDate = DateTime.Now;
            var gender = true;
            User user = new User("name", birthDate, gender);
            Console.WriteLine(user.Email.Valid);
            Console.ReadLine();
        }
    }
}
