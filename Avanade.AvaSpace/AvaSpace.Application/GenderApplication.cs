using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Interfaces.Applications;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    public class GenderApplication : ApplicationBase<Gender>, IGenderApplication
    {
        private readonly IGenderService _service;

        public GenderApplication(IGenderService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
