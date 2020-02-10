using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Mappers
{
    public class EventMapper : BaseMapper<Event>
    {
        public EventMapper()
        {
            ToTable("TB_EVENT");
            Map(e => e.Name).ToColumn("DS_EVENT_NAME");
            Map(e => e.Address.Street).ToColumn("DS_EVENT_STREET");
            Map(e => e.Address.Street).ToColumn("DS_EVENT_NUMBER");
            Map(e => e.Address.Neighborhood).ToColumn("DS_EVENT_NEIGHBORHOOD");
            Map(e => e.Address.Complement).ToColumn("DS_EVENT_COMPLEMENT");
            Map(e => e.Author.Id).ToColumn("ID_AUTHOR");
            Map(e => e.EventDate).ToColumn("DT_EVENT");
        }

    }
}
