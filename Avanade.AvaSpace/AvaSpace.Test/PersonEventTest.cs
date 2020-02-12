using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
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
    public class PersonEventTest : BaseTest
    {
        private readonly IPersonEventService _personEventService;
        public PersonEventTest()
        {
            var repository = new PersonEventRepository();
            _personEventService = new PersonEventService(repository);
        }

        public override void IntegratedTest()
        {
            PersonEvent personEvent = new PersonEvent();
            personEvent.EventId = Guid.NewGuid();
            personEvent.PersonId = Guid.NewGuid();

            _personEventService.Insert(personEvent);
        }
    }
}