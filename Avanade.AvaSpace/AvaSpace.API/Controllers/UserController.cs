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

        /// <summary>
        /// Retorna todos usuários ativos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _userApplication.Get(x => x.Active);
        }

        /// <summary>
        /// Retorna um usuário pelo id.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public User Get(Guid id)
        {
            return _userApplication.Get(id);
        }

        /// <summary>
        /// Cria um novo usuário.
        /// </summary>
        /// <returns></returns>
        [HttpPost("{id}")]
        public void Post([FromBody] User user)
        {
            _userApplication.Insert(user);
        }

        /// <summary>
        /// Atualiza os dados de um usuário.
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] User user)
        {
            user.Id = id;
            _userApplication.Update(user);
        }

        /// <summary>
        /// Desativa um usuário.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var user = _userApplication.Get(id);

            user.Active = false;

            _userApplication.Update(user);
        }
    }
}
