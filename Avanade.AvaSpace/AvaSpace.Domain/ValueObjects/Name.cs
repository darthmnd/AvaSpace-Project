using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.ValueObjects
{
    public class Name : Verifiable
    {
        public Name(string name)
        {
            Assert(() => !string.IsNullOrWhiteSpace(name));

            FullName = name;
        }

        public string FullName { get; private set; }

        public string SetName(string name)
        {
            return FullName = name;
        }
    }
}
