using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public class Post : BaseEntity
    {
        public Post()
        {
            Midias = new List<Midia>();

            Likes = new List<Like>();

            Comments = new List<Post>();
        }   
        
        public Guid AuthorId { get; set; }
        public User Author { get; set; }
        public Guid ParentId { get; set; }
        public string Text  { get; set; }
        public List<Midia> Midias { get; set; }
        public List<Like> Likes { get; set; }
        public List<Post> Comments { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
