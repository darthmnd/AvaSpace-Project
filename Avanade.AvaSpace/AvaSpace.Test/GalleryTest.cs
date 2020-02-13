using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace AvaSpace.Test
{
    [TestClass]
    public class GalleryTest : BaseTest
    {
        private readonly IGalleryService _service;

        public GalleryTest()
        {
            var repository = new GalleryRepository();

            _service = new GalleryService(repository);
        }


        [TestMethod]
        public override void IntegratedTest()
        {
            var userRepository = new UserRepository();

            var userId = userRepository.GetByName("Rebeca Fiorelli").First().Id;

            var gallery = new Gallery()
            {
                AuthorId = userId,
                Name = "Nova Galeria"
            };

            _service.Insert(gallery);

            //_service.delete(id);
        }

        [TestMethod]
        public void GetFeedByUserId()
        {
            _service.GetFeedByUserId(new Guid("E397367B-02FC-4F93-B222-9C24DF5FB36C"));
        }
    }
}
