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
    public class GenderController : ControllerBase
    {   
        private readonly IGenderApplication _app;

        public GenderController(IGenderApplication app)
        {
            _app = app;
        }

        /// <summary>
        /// Este metodo faz a requisao de todos os generos.
        /// </summary>
        // GET: api/Event

        [HttpGet]
        public IEnumerable<Gender> Get()
        {
            return _app.Get(x => x.Active);
        }



        /// <summary>
        /// Este metodo faz o cadastro de um novo genero.
        /// </summary>

        // POST: api/Event
        [HttpPost]
        public Guid Post([FromBody] Gender genero)
        {
            return _app.Insert(genero);
        }



        

        
    }
}
