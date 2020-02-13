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
        /// Este método faz a requisição de todas as mídias ativas.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<Midia> Get()
        {
            return _midiaApplication.Get(x => x.Active);
        }

        /// <summary>
        /// Este método faz a requisição de todas as mídias ativas do usuário passado.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Midia Get(Guid id)
        {
            return _midiaApplication.Get(id);
        }

        // POST: api/Midia
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Midia/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
