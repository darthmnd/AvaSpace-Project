using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class PersonEventTest : BaseTest
    {
        private readonly IPersonEventService _personEventService;
        public PersonEventTest()
        {
            var repository = new PersonEventRepository();
            _personEventService = new PersonEventService(repository);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            PersonEvent personEvent = new PersonEvent();
            personEvent.EventId = new Guid("AB658816-7EDD-4311-87FE-65CC472D1B93");
            personEvent.PersonId = new Guid("17B4286D-57E7-48DD-A734-021F73DBA611");

            _personEventService.Insert(personEvent);
        }
    }
}