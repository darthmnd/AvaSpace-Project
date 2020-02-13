using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AvaSpace.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostApplication _app;

        public PostController(IPostApplication app)
        {
            _app = app;
        }


        // GET: api/Post
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return _app.Get(x => x.Active);
        }

        // GET: api/Post/5
        [HttpGet("{id}")]
        public Post Get(Guid id)
        {
            return _app.Get(id);
        }

        // POST: api/Post
        [HttpPost]
        public Guid Post([FromBody] Post post)
        {
            return _app.Insert(post);

        }

        // PUT: api/Post/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Post post)
        {
            post.Id = id;

            _app.Update(post);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _app.Delete(id);
        }
    }
}
