using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Entities.ValueObjects
{
    public class Name : Verifiable
    {
        public Name(string name)
        {
            Assert(() => !string.IsNullOrWhiteSpace(name));
            Assert(() => !string.IsNullOrEmpty(name));

            FullName = name;
        }

        public string FullName { get; private set; }
    }
}
