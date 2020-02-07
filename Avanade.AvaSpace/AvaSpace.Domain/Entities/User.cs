using AvaSpace.Domain.ValueObjects;
using System;

namespace AvaSpace.Domain.Entities
{
    public class User
    {
        public User (string fullName, string emailAddress, DateTime birthDate, int gender)
        {
            Name.SetName(fullName);
            Email.SetEmail(emailAddress);
            BirthDate = birthDate;
            Gender = gender;
        }
        public Name Name { get; private set; }
        public Email Email { get; private set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
    }
}
