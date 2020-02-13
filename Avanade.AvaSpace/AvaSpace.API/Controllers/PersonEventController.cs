using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonEventController : ControllerBase
    {
        private readonly IPersonEventApplication _app;
        public PersonEventController(IPersonEventApplication app) 
        {
            _app = app;
        }


        [HttpGet("{id}")]
        public PersonEvent Get(Guid id)
        {            
            return _app.Get(id);
        }

        // POST: api/PersonEvent
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/PersonEvent/5
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
