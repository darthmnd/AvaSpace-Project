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
    public class EventTest : BaseTest
    {
        private readonly IEventService _eventService;
        public EventTest()
        {
            var repository = new EventRepository();
            _eventService = new EventService(repository);
        }


        [TestMethod]
        public override void IntegratedTest()
        {
            User author = new User()
            {
                Name = "Teste",
                Email = "Teste@gmail.com",
                Birthday = DateTime.Now,
                GenderId = new Guid("E6C82CD5-8C61-4850-A54D-42C8E2A7AA19"),
                CoverId = new Guid("E6DE7EDF-8DCE-462F-931D-3CA37647FB8F"),
                AvatarId = new Guid("13DF0D5D-9867-41C4-9AE2-640D9A355606"),
            };
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                EventDate = DateTime.Now,
                Street = "Rua Teste ABC",
                Number = 256,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751-000",
                AuthorId = author.Id
            };
            _eventService.Insert(evento);
        }
    }
}
