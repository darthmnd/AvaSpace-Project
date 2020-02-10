using System.Text.RegularExpressions;

namespace AvaSpace.Domain.Entities.ValueObjects
{
    public class Address : Verifiable
    {
        public Address(string zipCode, string street, int number, string neighborhood, string complement = "")
        {
            bool isValidZipCode = Regex.IsMatch(zipCode ?? string.Empty, @"^\d{5}-\d{3}$");

            Assert(() => isValidZipCode && !string.IsNullOrWhiteSpace(street) && (number > 0) && !string.IsNullOrWhiteSpace(neighborhood));

            ZipCode = zipCode;
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            Complement = complement;
        }

        public string ZipCode { get; private set; }

        public string Street { get; private set; }

        public int Number { get; private set; }

        public string Neighborhood { get; private set; }

        public string Complement { get; private set; }
    }
}
