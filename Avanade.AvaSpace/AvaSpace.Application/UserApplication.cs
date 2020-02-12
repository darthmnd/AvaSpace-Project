using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    public class UserApplication : ApplicationBase<User>, IUserApplication
    {
        private readonly IUserService _service;

        public UserApplication(IUserService Service) : base(Service)
        {
            _service = Service;
        }
    }
}
