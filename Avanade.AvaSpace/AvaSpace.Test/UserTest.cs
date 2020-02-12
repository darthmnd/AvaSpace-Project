using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository;
using AvaSpace.Repository.Mappers;
using AvaSpace.Repository.Repositories;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class UserTest : BaseTest
    {
        private readonly IUserService _service;

        public UserTest()
        {
            var repository = new UserRepository();
            _service = new UserService(repository);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void NameNull()
        {
            User user = new User()
            {
                Name = "",
                Email = "Teste@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606")
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void EmailNull()
        {
            User user = new User()
            {
                Name = "Maria Teste",
                Email = "",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606")
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmailInvalid()
        {
            User user = new User()
            {
                Name = "Maria Teste",
                Email = "teste",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606")
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void PasswordNull()
        {
            User user = new User()
            {
                Name = "Maria Teste",
                Email = "maria@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
                Password = null
            };
            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PasswordInvalid()
        {
            User user = new User()
            {
                Name = "Maria Teste",
                Email = "PasswordInvalid@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
                Password = "1234567"
            };

            _service.Insert(user);
        }

       [TestMethod]
       [ExpectedException(typeof(ArgumentException))]
        public void BirthdayInvalid()
        {
            User user = new User()
            {
                Name = "Maria Teste",
                Email = "BirthdayInvalid@gmail.com",
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
                Password = "123456789",
            };

            _service.Insert(user);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GenderNull()
        {
            User user = new User()
            {
                Name = "GenderNull",
                Email = "GenderNull@gmail.com",
                Birthday = DateTime.Now,
                GenderId = Guid.Empty,
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
                Password = "123456789"
            };

            _service.Insert(user);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            User user = new User()
            {
                Name = "IntegratedTeste",
                Email = "IntegratedTeste@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
                Password = "123456789"
            };

            _service.Insert(user);
        }
    }
}
