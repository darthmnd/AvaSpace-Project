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
        /// Retorna todos os status.
        /// </summary>
        [HttpGet]
        public IEnumerable<InviteStatus> Get()
        {
            return _app.Get(x => x.Active);
        }

        /// <summary>
        /// Retorna status por id.
        /// </summary>
        [HttpGet("{id}")]
        public InviteStatus Get(Guid id)
        {
            return _app.Get(id);
        }

        /// <summary>
        /// Cria um novo status.
        /// </summary>
        [HttpPost]
        public Guid Post([FromBody] InviteStatus invite)
        {
            return _app.Insert(invite);
        }

        /// <summary>
        /// Atualiza um status.
        /// </summary>
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] InviteStatus invite)
        {
            invite.Id = id;

            _app.Update(invite);
        }

        /// <summary>
        /// Desativa o status pelo id.
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
