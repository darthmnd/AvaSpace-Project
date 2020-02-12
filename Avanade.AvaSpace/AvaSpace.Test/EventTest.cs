using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository.Repositories;
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
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                Description = "este evento serve para x y z.",
                EventDate = DateTime.Now,
                Street = "Rua Teste ABC",
                Number = 256,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751-000",
                AuthorId = new Guid("17B4286D-57E7-48DD-A734-021F73DBA611")
            };
            _eventService.Insert(evento);
        }
    }
}
