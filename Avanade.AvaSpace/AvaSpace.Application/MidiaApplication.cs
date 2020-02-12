using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    public class MidiaApplication : ApplicationBase<Midia>, IMidiaApplication
    {
        private readonly IMidiaService _service;

        public MidiaApplication(IMidiaService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
