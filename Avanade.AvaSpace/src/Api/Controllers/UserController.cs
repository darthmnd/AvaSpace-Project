using System;
using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _app;

        public UserController(IUserApplication app)
        {
            _app = app;
        }
        
        public User Get(Guid id)
        {
            return _app.Get(id);
        }
    }
}