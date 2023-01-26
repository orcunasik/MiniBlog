using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;

namespace MiniBlog.Entities.Concretes
{
    public class Blog : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
