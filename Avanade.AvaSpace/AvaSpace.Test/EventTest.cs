using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Entities.ValueObjects;
using AvaSpace.Domain.Interfaces.Services;
using AvaSpace.Domain.Services;
using AvaSpace.Repository;
using AvaSpace.Repository.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Test
{
    [TestClass]
    public class EventTest
    {
        private readonly IEventService _eventService;
        public EventTest() 
        {
            RegisterMappers.Register();
            var repository = new EventRepository();
            _eventService = new EventService(repository);
        }

        [TestMethod]
        public void IntegratedMethod()
        {
            User author = new User("Nath","nathalispinula@gmail.com", DateTime.Now, "Female");
            Address address = new Address("02751-000", "Rua Xyz.", 256, "ZN", "TESTE");
            Event evento = new Event(author, "Evento", address, DateTime.Now);
            _eventService.Insert(evento);
        }
    }
}
