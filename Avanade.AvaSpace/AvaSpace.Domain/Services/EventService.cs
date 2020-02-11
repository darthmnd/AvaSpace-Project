using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using AvaSpace.Domain.Interfaces.Services;

namespace AvaSpace.Domain.Services
{
    public class EventService : ServiceBase<Event>, IEventService
    {
        private readonly IEventRepository _eventService;
        public EventService(IEventRepository eventService) : base(eventService) {
            _eventService = eventService;
        }
    }
}
