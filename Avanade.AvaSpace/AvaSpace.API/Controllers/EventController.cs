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
        /// Este metodo faz a requisao de todos os eventos.
        /// </summary>
        // GET: api/Event

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _app.Get(x => x.Active);
        }

        /// <summary>
        /// Este metodo faz a requisao de um evento por id.
        /// </summary>
        // GET: api/Event/5
        [HttpGet("{id}")]
        public Event Get(Guid id)
        {
            return _app.Get(id);
        }


        /// <summary>
        /// Este metodo faz o cadastro do evento.
        /// </summary>
        
        // POST: api/Event
        [HttpPost]
        public Guid Post([FromBody] Event evento )
        {
            return _app.Insert(evento);
        }


        /// <summary>
        /// Este metodo faz atualizacao de um evento.
        /// </summary>   

        // PUT: api/Event/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Event evento)
        {
            evento.Id = id;

            _app.Update(evento);
        }


        /// <summary>
        /// Este metodo faz a remocao de um evento por id.
        /// </summary>
       
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var invite = _app.Get(id);

            invite.Active = false;

            _app.Update(invite);
        }
    }
}
