using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaSpace.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AvaSpace.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        [ApiController]
        [Route("[controller]")]
        public class UserController : Controller
        {
            private readonly IUserService _userService;
            ILogger _logger;
            public UserController(IUserService userService, ILogger<UserController> logger)
            {
                _logger = logger;
                _userService = userService;
            }

            /// <summary>
            /// Returns a json of all users in database.
            /// </summary>
            [HttpGet]
            public async Task<IEnumerable<User>> Get()
            {
                _logger.LogInformation("Method Get all users executed. DateTime: " + DateTime.Now.ToString());
                var users = await _userService.ReadAsync();
                return users;
            }

            /// <summary>
            /// Returns the user information found with the id passed.
            /// </summary>
            [HttpGet("{id}")]
            public async Task<IEnumerable<User>> Get(int id)
            {
                var user = await _userService.ReadAsync(id);
                return user;
            }

            /// <summary>
            /// Create a new user.
            /// </summary>
            [HttpPost]
            public int Post([FromBody]User user)
            {
                var qtd = _userService.Create(user);
                return qtd;
            }

            // PUT api/<controller>/5
            [HttpPut]
            public async Task<int> Put([FromBody]User user)
            {
                var qtd = _userService.UpdateAsync(user);
                return await qtd;
            }

            // DELETE api/<controller>/5
            [HttpDelete("{id}")]
            public async Task<int> Delete(int id)
            {
                var qtd = _userService.DeactivateAsync(id);
                return await qtd;
            }
        }
    }
}
