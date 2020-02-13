using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class GenderTest : BaseTest
    {
        private readonly IGenderService _service;
        public GenderTest()
        {
            var repository = new GenderRepository();
            _service = new GenderService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ValidateTest()
        {
            var gender = new Gender("");

            _service.Insert(gender);

        }
        
        [TestMethod]
        public override void IntegratedTest()
        {
            var gender = new Gender() 
            { 
                Description = "N�o Bin�rio"
            };

            _service.Insert(gender);
        }
    }
}