using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    class MidiaApplication : ApplicationBase<Midia>, IMidiaApplication
    {
        private readonly IMidiaService _midiaService;
        public MidiaApplication(IMidiaService midiaService) : base(midiaService)
        {
            _midiaService = midiaService;
        }
    }
}
