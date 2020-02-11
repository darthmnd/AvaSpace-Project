using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class EventMapper : BaseMapper<Event>
    {
        public EventMapper()
        {
            ToTable("TB_EVENT");
            Map(e => e.Name).ToColumn("DS_NAME");
            Map(e => e.Address.Street).ToColumn("DS_STREET");
            Map(e => e.Address.ZipCode).ToColumn("DS_ZIPCODE");
            Map(e => e.Address.Number).ToColumn("INT_NUMBER");
            Map(e => e.Address.Neighborhood).ToColumn("DSC_NEIGHBORHOOD");
            Map(e => e.Address.Complement).ToColumn("DSC_COMPLEMENT");
            Map(e => e.AuthorId).ToColumn("ID_AUTHOR");
            Map(e => e.EventDate).ToColumn("DT_EVENT");
        }

    }
}