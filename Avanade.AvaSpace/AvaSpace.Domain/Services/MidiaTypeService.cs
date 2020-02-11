using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Services
{
    public class MidiaTypeService : ServiceBase<MidiaType>, IMidiaTypeService
    {
        private readonly IMidiaTypeRepository _midiaTypeService;
        public MidiaTypeService(IMidiaTypeRepository midiaTypeService) : base(midiaTypeService)
        {
            _midiaTypeService = midiaTypeService;
        }

    }
}
