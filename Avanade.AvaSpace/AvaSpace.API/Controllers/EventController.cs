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
    public class EventController : ControllerBase
    {

        private readonly IEventApplication _app;

        public EventController(IEventApplication app)
        {
            _app = app;
        }

        /// <summary>
        /// Retorna todos os eventos ativos.
        /// </summary>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _app.Get(x => x.Active);
        }

        /// <summary>
        /// Retorna um evento pelo id.
        /// </summary>
        [HttpGet("{id}")]
        public Event Get(Guid id)
        {
            return _app.Get(id);
        }


        /// <summary>
        /// Cadastra um novo evento.
        /// </summary>
        [HttpPost]
        public Guid Post([FromBody] Event evento )
        {
            return _app.Insert(evento);
        }


        /// <summary>
        /// Atualiza os dados de um evento pelo id.
        /// </summary>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Event evento)
        {
            evento.Id = id;

            _app.Update(evento);
        }


        /// <summary>
        /// Desativa um evento pelo id.
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var invite = _app.Get(id);

            invite.Active = false;

            _app.Update(invite);
        }
    }
}
