using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
        /// Retorna todos os posts ativos.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _app.Get(x => x.Active);
        }

        /// <summary>
        /// Retorna um post.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
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
        /// Atualiza os dados de um post.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="post"></param>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Post post)
        {
            post.Id = id;

            _app.Update(post);
        }

        /// <summary>
        /// Desativa um post pelo id.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var post = _app.Get(id);
            post.Active = false;
            _app.Update(post);
        }
    }
}
