using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Mappers
{
    public class LikeMapper : BaseMapper<Like>
    {
        public LikeMapper()
        {
            ToTable("TB_LIKES");
            Map(e => e.User.Id).ToColumn("ID_USER");
            Map(e => e.Post.Id).ToColumn("ID_POST");
        }
    }
}
