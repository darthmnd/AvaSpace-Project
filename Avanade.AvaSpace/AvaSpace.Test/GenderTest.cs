using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class GenderTest
    {
        private readonly IGenderService _service;

        public GenderTest()
        {
            RegisterMappers.Register();

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
        public void IntegratedTest()
        {
            var gender = new Gender("Indefinido");

            _service.Insert(gender);
        }
    }
}