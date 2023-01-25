using MiniBlog.Entities.Abstractions;
using System;

namespace MiniBlog.Entities.Concretes
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsActive { get; set; } = true;
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
