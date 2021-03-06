﻿using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Mappers
{
    public class LikeMapper : BaseMapper<Like>
    {
        public LikeMapper()
        {
            ToTable("TB_LIKE");
            Map(e => e.UserId).ToColumn("ID_USER");
            Map(e => e.PostId).ToColumn("ID_POST");
        }
    }
}
