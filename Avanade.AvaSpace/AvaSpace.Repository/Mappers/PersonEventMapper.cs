using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Mappers
{
    public class PersonEventMapper : BaseMapper<PersonEvent>
    {
        public PersonEventMapper() 
        {
            ToTable("TB_PERSON_EVENT");
            Map(e => e.PersonId).ToColumn("PERSON_ID");
            Map(e => e.EventId).ToColumn("EVENT_ID");
        }
    }
}