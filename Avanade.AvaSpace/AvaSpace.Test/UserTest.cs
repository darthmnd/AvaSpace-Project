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
        public override void IntegratedTest()
        {
            var user = new User()
            {
                Birthday = new DateTime(1990, 08, 08),
                Name = "TESTE",
                Email = "teste@gmail.com",
                Password = "12345678",
                AvatarId = new Guid("16A1BCE4-2F14-455A-97FE-164589E32E46"),
                GenderId = new Guid("D42AA751-73C0-4BA6-A072-60261D74B58A"),
            };

            var id = _service.Insert(user);

            //_service.Delete(id);
        }

        [TestMethod]
        public void GetById()
        {
            var result = _service.Get(new Guid("DAAEE0A1-3E61-431F-A1AF-5BC373D6754C"));
        }
    }
}
