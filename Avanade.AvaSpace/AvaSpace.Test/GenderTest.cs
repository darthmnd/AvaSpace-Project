using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class GenderTest
    {
        private readonly IGenderService _genderService;
        public GenderTest() 
        {
            var repository = new GenderRepository();
            _genderService = new GenderService(repository);
        }
        [TestMethod]
        public void GenderValidation()
        {
            var gender = new Gender();
            _genderService.Insert(gender);
        }
    }
}
