using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserApplication _userApplication;
        public UserController(IUserApplication userApplication)
        {
            _userApplication = userApplication;
        }
        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userApplication.Get(x => x.Active);
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _userApplication.Get(id);
        }

        // POST: api/User
        [HttpPost("{id}")]
        public void Post([FromBody] User user)
        {
            _userApplication.Insert(user);
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] User user)
        {
            user.Id = id;
            _userApplication.Update(user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _userApplication.Delete(id);
        }
    }
}
