﻿using AvaSpace.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AvaSpace.Repository.Mappers
{
    public class InviteStatusMapper : BaseMapper<InviteStatus>
    {
        public InviteStatusMapper()
        {
            ToTable("TB_INVITE_STATUS");
            Map(e => e.Description).ToColumn("DS_INVITE_STATUS");
        }
    }
}
