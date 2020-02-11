using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Domain.Services
{
    public class PersonEventService : ServiceBase<PersonEvent>, IPersonEventService
    {
        private readonly IPersonEventRepository _personEventRepository;
        public PersonEventService(IPersonEventRepository personEventRepository) : base(personEventRepository)
        {
            _personEventRepository = personEventRepository;
        }
    }
}
