using AvaSpace.Domain.Entities;

namespace AvaSpace.Repository.Mappers
{
    public class GalleryMapper : BaseMapper<Gallery>
    {
        public GalleryMapper()
        {
            ToTable("TB_GALLERY");
            Map(e => e.AuthorId).ToColumn("ID_USER");
            Map(e => e.Name).ToColumn("NM_GALLERY");
        }
    }
}
