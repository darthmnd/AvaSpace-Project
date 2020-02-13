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
            personEvent.EventId = new Guid("647E941F-A03D-4AA1-9F32-CE9A1A5B883E");
            personEvent.PersonId = new Guid("B82230EA-6A0C-4971-ACDD-F805F6F3F07B");

            _personEventService.Insert(personEvent);
        }
    }
}