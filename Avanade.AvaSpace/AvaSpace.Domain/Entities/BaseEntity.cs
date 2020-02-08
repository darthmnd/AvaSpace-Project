using System;

namespace AvaSpace.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = new Guid();
            DateCreate = DateTime.Now;
            DateUpdate = DateTime.Now;
        }
        public Guid Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool Active { get; set; }
    }
}
