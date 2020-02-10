using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Interfaces.Applications
{
    interface IGenderApplication
    {
        public interface IGenderApplication : IApplicationBase<Gender>
        {
        }
    }
}
