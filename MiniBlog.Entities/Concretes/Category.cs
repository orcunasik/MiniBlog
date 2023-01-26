using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace MiniBlog.Entities.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
