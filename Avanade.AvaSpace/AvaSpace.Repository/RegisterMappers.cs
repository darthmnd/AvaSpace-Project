using AvaSpace.Domain.Entities;
using AvaSpace.Repository.Mappers;
using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;

namespace AvaSpace.Repository
{
    public static class RegisterMappers
    {
        public static void Register() 
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new BaseMapper<BaseEntity>());
                config.AddMap(new EventMapper());
                config.AddMap(new GalleryMapper());
                config.AddMap(new GenderMapper());
                config.AddMap(new InviteMapper());
                config.AddMap(new InviteStatusMapper());
                config.AddMap(new LikeMapper());
                config.AddMap(new MidiaMapper());
                config.AddMap(new MidiaTypeMapper());
                config.AddMap(new PersonEventMapper());
                config.AddMap(new PostMapper());
                config.AddMap(new UserMapper());
                config.ForDommel();
            });
        }
    }
}
