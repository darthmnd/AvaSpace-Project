﻿using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Midias = new List<Midia>();

            Likes = new List<User>();

            Comments = new List<Post>();
        }   
        
        public User Author { get; set; }
        public Guid ParentId { get; set; }
        public string Text  { get; set; }
        public List<Midia> Midias { get; set; }
        public List<User> Likes { get; set; }
        public List<Post> Comments { get; set; }
    }
}
