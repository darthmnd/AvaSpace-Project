using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class LikeTest : BaseTest
    {
        private readonly ILikeService _service;

        public LikeTest()
        {
            var repository = new LikeRepository();

            _service = new LikeService(repository);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var like = new Like()
            {
                PostId = new Guid("F1B286BF-E575-4624-9562-5AF7F2502019"),
                UserId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };

            var result = _service.Insert(like);
        }
    }
}
