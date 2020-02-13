using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _app;

        public PostController(IPostApplication app)
        {
            _app = app;
        }

        /// <summary>
        /// Retorna todos os posts do usuário passado.
        /// </summary>
        /// <returns></returns>[HttpGet("{id}")]
        public Post Get(Guid id)
        {
            return _app.Get(id);
        }

        /// <summary>
        /// Cria um novo post. 
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Guid Post([FromBody] Post post)
        {
            return _app.Insert(post);

        }

        /// <summary>
        /// Atualiza os dados de um usuário. 
        /// </summary>
        /// <returns></returns>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Post post)
        {
            post.Id = id;

            _app.Update(post);
        }

        /// <summary>
        /// Desativa um post pelo id.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var user = _app.Get(id);

            user.Active = false;

            _app.Update(user);
        }
    }
}
