﻿using AvaSpace.Domain.Entities;
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
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AuthorIdInvalid() 
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
                AuthorId = Guid.Empty
            };

            _eventService.Insert(evento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void EventDateInvalid()
        {
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                Description = "este evento serve para x y z.",
                EventDate = DateTime.MinValue,
                Street = "Rua Teste ABC",
                Number = 256,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751-000",
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };

            _eventService.Insert(evento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void DescriptionInvalid()
        {
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                Description = "",
                EventDate = DateTime.Now,
                Street = "Rua Teste ABC",
                Number = 256,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751-000",
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };

            _eventService.Insert(evento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void NumberInvalid()
        {
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                Description = "Eventooo",
                EventDate = DateTime.Now,
                Street = "Rua Teste ABC",
                Number = -1,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751-000",
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };

            _eventService.Insert(evento);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CepInvalid()
        {
            Event evento = new Event()
            {
                Name = "Evento Teste 2",
                Description = "Eventooo",
                EventDate = DateTime.Now,
                Street = "Rua Teste ABC",
                Number = 256,
                Complement = "A",
                Neighborhood = "TESTE",
                ZipCode = "02751000",
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };

            _eventService.Insert(evento);
        }

        [TestMethod]
        public override void IntegratedTest()
        {
            Event evento = new Event()
            {
                Name = "MEETUP AVASPACE",
                Description = "Jesus salvará.",
                EventDate = DateTime.Now,
                Street = "Rua Gloria",
                Number = 256,
                Complement = "Amém",
                Neighborhood = "Céu",
                ZipCode = "02751-000",
                AuthorId = new Guid("7F21704C-4E76-4FC2-BDD2-98BD03D86115")
            };
            _eventService.Insert(evento);
        }
    }
}
