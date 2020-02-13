using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
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
                Name = "Amanda",
                Email = "umteste@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("7CFCB9D0-1ACD-459A-AB07-7E089EA7CF60"),
                CoverId = new Guid("0BA473C2-589B-4D59-BB9C-04567398344D"),
                AvatarId = new Guid("A96EA072-31D2-4D12-B5B3-8DE13E7D5C07")
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
                GenderId = new Guid("DB8DBEE8-DD02-4D63-8F06-319A8CA7A4D7"),
                CoverId = new Guid("1F0B5B71-B9BD-4F44-935B-026FD77D2226"),
                AvatarId = new Guid("1F0B5B71-B9BD-4F44-935B-026FD77D2226"),
                Password = "123456789",
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
                GenderId = new Guid("B664BE4A-D2BE-475B-B3A2-FC6A08644EE2"),
                CoverId = new Guid("4B8AF89A-788F-4246-8085-6B21C5196EB3"),
                AvatarId = new Guid("182FAFB4-5CEA-415D-894A-29FE2566ED46"),
                Password = "123456789"
            };

            _service.Insert(user);
        }
    }
}
