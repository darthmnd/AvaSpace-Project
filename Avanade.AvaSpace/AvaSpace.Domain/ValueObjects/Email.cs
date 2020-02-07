using System.Text.RegularExpressions;

namespace AvaSpace.Domain.ValueObjects
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

        public string SetEmail(string email) 
        {
            return EmailAddress = email;
        }
    }
}
