using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AvaSpace.Test
{
    [TestClass]
    public class PersonEventTest
    {
        private readonly IPersonEventService _personEventService;
        public PersonEventTest() 
        {
            RegisterMappers.Register();
            var repository = new PersonEventRepository();
            _personEventService = new PersonEventService(repository);
        }

        [TestMethod]
        public void Integrated()
        {
            PersonEvent personEvent = new PersonEvent();
            personEvent.EventId = Guid.NewGuid();
            personEvent.PersonId = Guid.NewGuid();

            _personEventService.Insert(personEvent);
        }
    }
}