using MiniBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Entities.Concrete
{
    public class Comment : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Text { get; set; }
    }
}
