using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AvaSpace.Domain.Entities.ValueObjects
{
    public class Email : Verifiable
    {
        public Email(string emailAddress)
        {
            Assert(() => Regex.IsMatch(emailAddress ?? string.Empty, @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"));

            EmailAddress = emailAddress;
        }

        public string EmailAddress { get; private set; }

        public static Email ToEmail(string emailAddress) => new Email(emailAddress);

        public override string ToString() => EmailAddress;

        public static implicit operator Email(string v)
        {
            throw new NotImplementedException();
        }
    }
}
