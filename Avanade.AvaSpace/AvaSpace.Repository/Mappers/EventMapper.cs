using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class EventMapper : BaseMapper<Event>
    {
        public EventMapper()
        {
            ToTable("TB_EVENT");
            Map(e => e.Name).ToColumn("NM_EVENT");
            Map(e => e.Description).ToColumn("DS_EVENT");
            Map(e => e.Street).ToColumn("DS_STREET");
            Map(e => e.ZipCode).ToColumn("DS_ZIPCODE");
            Map(e => e.Number).ToColumn("INT_NUMBER");
            Map(e => e.Neighborhood).ToColumn("DS_NEIGHBORHOOD");
            Map(e => e.Complement).ToColumn("DS_COMPLEMENT");
            Map(e => e.AuthorId).ToColumn("ID_AUTHOR");
            Map(e => e.EventDate).ToColumn("DT_EVENT");
        }

    }
}