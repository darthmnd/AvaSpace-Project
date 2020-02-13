using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MidiaController : ControllerBase
    {
        private readonly IMidiaApplication _midiaApplication;
        public MidiaController(IMidiaApplication midiaApplication)
        {
            _midiaApplication = midiaApplication;
        }

        /// <summary>
        /// Retorna todas as mídias ativas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Midia> Get()
        {
            return _midiaApplication.Get(x => x.Active);
        }

        /// <summary>
        /// Retorna todas as mídias ativas do usuário passado.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Midia Get(Guid id)
        {
            return _midiaApplication.Get(id);
        }

        /// <summary>
        /// Insere uma imagem em determinado post.
        /// </summary>
        /// <returns></returns>
        [HttpPost("{id}")]
        public void Post(Guid id, [FromBody] Midia midia)
        {
            _midiaApplication.Insert(midia);   
        }

        /// <summary>
        /// Desativa a midia de uma imagem.
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var midia = _midiaApplication.Get(id);
            _midiaApplication.Update(midia);
        }
    }
}
