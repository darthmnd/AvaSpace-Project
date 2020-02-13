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
    public class InviteController : ControllerBase
    {
        private readonly IInviteApplication _app;

        public InviteController(IInviteApplication app)
        {
            _app = app;
        }


        // GET: api/Invite
        [HttpGet]
        public IEnumerable<Invite> Get()
        {
            return _app.Get(x => x.Active);
        }

        // GET: api/Invite/5
        [HttpGet("{id}")]
        public Invite Get(Guid id)
        {
            return _app.Get(id);
        }

        // POST: api/Invite
        [HttpPost]
        public Guid Post([FromBody] Invite invite)
        {
            return _app.Insert(invite);
        }

        // PUT: api/Invite/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Invite invite)
        {
            invite.Id = id;

            _app.Update(invite);
        }

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
