using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class PostTest : BaseTest
    {
        private readonly IPostService _service;

        public PostTest()
        {
            var repository = new PostRepository();

            _service = new PostService(repository);
        }


        [TestMethod]
        public override void IntegratedTest()
        {
            var post = new Post()
            {
                ParentId = null,
                AuthorId = new Guid("17B4286D-57E7-48DD-A734-021F73DBA611"),
                Text = "Fui pa praia! Foi MARA!",
            };

            var id = _service.Insert(post);
        }

        [TestMethod]
        public void GetTimelime()
        {
            var results = _service.Get(x => x.AuthorId == new Guid("508FB614-01B6-40F9-8149-654B87FD8BBD"));
        }
    }
}
