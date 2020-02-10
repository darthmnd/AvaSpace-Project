using AvaSpace.Domain.Entities;
using AvaSpace.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Repositories
{
    public class EventRepository : RepositoryBase<Event>, IEventRepository
    {
    }
}
