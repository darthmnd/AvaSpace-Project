using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class MidiaTypeTest : BaseTest
    {
        private readonly IMidiaTypeService _service;

        public MidiaTypeTest()
        {
            var repository = new MidiaTypeRepository();

            _service = new MidiaTypeService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTest()
        {
            var midiaType = new MidiaType();

            _service.Insert(midiaType);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            var type = new MidiaType
            {
                Description = "TESTEEE",
                Extensions = "jpeg,jpg,gif,png"
            };

           _service.Insert(type);

            //_service.Delete(id);
        }
    }
}
