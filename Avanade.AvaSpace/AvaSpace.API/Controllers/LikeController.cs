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
    public class LikeController : ControllerBase
    {
        private readonly ILikeApplication _likeApplication;

        public LikeController(ILikeApplication likeApplication) 
        {
            _likeApplication = likeApplication;
        }

        /// <summary>
        /// Retorna o like pelo id.
        /// </summary>
        /// <param name="id"></param>
        [HttpGet("{id}")]
        public Like Get(Guid id)
        {
            return _likeApplication.Get(id);
        }

        /// <summary>
        /// Dá um like no post desejado.
        /// </summary>
        [HttpPost]
        public void Post([FromBody] Like like)
        {
            _likeApplication.Insert(like);
        }

        /// <summary>
        /// Desativa um like pelo id.
        /// </summary>
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var like = _likeApplication.Get(id);
            like.Active = false;
            _likeApplication.Update(like);
        }
    }
}
