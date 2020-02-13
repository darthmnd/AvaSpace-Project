﻿using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Gallery : BaseEntity
    {
        public Gallery() {
            Author = new User();
            Midias = new List<Midia>();
        }

        public string Name { get; set; }
        public List<Midia> Midias { get; set; }

        public Guid AuthorId { get; set; }
        public User Author { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Name))
                throw new ArgumentNullException("'Name' não foi preenchido");

            if (AuthorId == Guid.Empty)
                throw new ArgumentNullException("'AuthorId' não foi preenchido");

        }
    }
}
