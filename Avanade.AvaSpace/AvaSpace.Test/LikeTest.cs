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
                PostId = new Guid("783ADAC8-26C4-4D43-A74B-1D2D51C68A0C"),
                UserId = new Guid("7C5E0E60-726F-422E-9E48-9C892F9F653A")
            };

            var result = _service.Insert(like);
        }
    }
}
