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
            personEvent.EventId = new Guid("B7192C75-32F5-4184-BF1C-ED85680CDC67");
            personEvent.PersonId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115");

            _personEventService.Insert(personEvent);
        }
    }
}