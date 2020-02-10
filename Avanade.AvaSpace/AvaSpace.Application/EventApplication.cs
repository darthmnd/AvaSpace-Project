using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Applications;
using AvaSpace.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Application
{
    public class EventApplication : ApplicationBase<Event>, IEventApplication
    {
        private readonly IEventService _eventService;
        public EventApplication(IEventService eventService) : base(eventService)
        {
            _eventService = eventService;
        }
    }
}
