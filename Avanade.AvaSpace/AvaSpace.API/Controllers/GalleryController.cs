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
    public class GalleryController : ControllerBase
    {
        private readonly IGalleryApplication _app;

        public GalleryController(IGalleryApplication app)
        {
            _app = app;
        }
        
        /// <summary>
        /// Retorna a galeria do usuário pelo id.
        /// </summary>
        [HttpGet("{id}")]
        public Gallery Get(Guid id)
        {
            return _app.Get(id);
        }
    }
}
