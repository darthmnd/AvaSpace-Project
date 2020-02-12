using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    public class MidiaTypeApplication : ApplicationBase<MidiaType>, IMidiaTypeApplication
    {
        private readonly IMidiaTypeService _service;

        public MidiaTypeApplication(IMidiaTypeService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
