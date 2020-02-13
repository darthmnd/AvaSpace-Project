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
    public class InviteStatusController : ControllerBase
    {
        private readonly IInviteStatusApplication _app;

        public InviteStatusController(IInviteStatusApplication app)
        {
            _app = app;
        }


        /// <summary>
        /// Este metodo faz a requisao de todos os status.
        /// </summary>
        // GET: api/Invite
        [HttpGet]
        public IEnumerable<InviteStatus> Get()
        {
            return _app.Get(x => x.Active);
        }

        /// <summary>
        /// Este metodo faz a requisao de um status por id.
        /// </summary>
        // GET: api/Invite/5
        [HttpGet("{id}")]
        public InviteStatus Get(Guid id)
        {
            return _app.Get(id);
        }

        /// <summary>
        /// Este metodo faz o cadastro do um novo status.
        /// </summary>
        // POST: api/Invite
        [HttpPost]
        public Guid Post([FromBody] InviteStatus invite)
        {
            return _app.Insert(invite);
        }

        /// <summary>
        /// Este metodo faz atualizacao de um status.
        /// </summary>   
        // PUT: api/Invite/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] InviteStatus invite)
        {
            invite.Id = id;

            _app.Update(invite);
        }

        /// <summary>
        /// Este metodo faz a remocao de um status por id.
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
