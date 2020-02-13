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
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115"),
                Text = "Será que agora vai?",
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
