using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class EventMapper : BaseMapper<Event>
    {
        public EventMapper()
        {
            ToTable("TB_EVENT");
            Map(e => e.Name).ToColumn("DS_NAME");
            Map(e => e.Street).ToColumn("DS_STREET");
            Map(e => e.ZipCode).ToColumn("DS_ZIPCODE");
            Map(e => e.Number).ToColumn("INT_NUMBER");
            Map(e => e.Neighborhood).ToColumn("DSC_NEIGHBORHOOD");
            Map(e => e.Complement).ToColumn("DSC_COMPLEMENT");
            Map(e => e.AuthorId).ToColumn("ID_AUTHOR");
            Map(e => e.EventDate).ToColumn("DT_EVENT");
        }

    }
}