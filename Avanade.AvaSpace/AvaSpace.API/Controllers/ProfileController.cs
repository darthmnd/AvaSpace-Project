using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IPostApplication _app;

        public ProfileController(IPostApplication app)
        {
            _app = app;
        }

        /// <summary>
        /// Retorna o feed do id passado.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}/feed/")]
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

        /// <summary>
        /// Retorna a timeline do id passado.
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}/timeline/")]
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