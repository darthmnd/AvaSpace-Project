using System;
using System.Collections.Generic;

namespace AvaSpace.Domain.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DateCreate = DateTime.Now;
            DateUpdate = DateTime.Now;
            Active = true;
        }
        public Guid Id { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public bool Active { get; set; }
        public abstract void Validate();
    }
}
