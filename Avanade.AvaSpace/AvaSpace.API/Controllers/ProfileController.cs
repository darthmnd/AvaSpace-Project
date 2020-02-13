using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AvaSpace.Api.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IPostApplication _app;

        public ProfileController(IPostApplication app)
        {
            _app = app;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}/feed/")]
        public ObjectResult GetFeedByUserId(Guid id)
        {
            try
            {
                if (Guid.Empty == id) throw new ArgumentException("Id inválido");

                return Ok(_app.GetFeedByUserId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{id}/timeline/")]
        public ObjectResult GetTimeLine(Guid id)
        {
            try
            {
                if (Guid.Empty == id) throw new ArgumentException("Id inválido");

                return Ok(_app.Get(p => p.AuthorId == id));
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}