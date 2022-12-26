using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Entities.Concretes
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
