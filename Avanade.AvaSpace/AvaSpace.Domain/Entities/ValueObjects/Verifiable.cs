using System;

namespace AvaSpace.Domain.Entities.ValueObjects
{
    public abstract class Verifiable
    {
        public bool Valid { get; private set; }
        protected void Assert(Func<bool> expression) => Valid = expression?.Invoke() ?? false;
    }
}
