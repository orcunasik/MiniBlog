using MiniBlog.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Entities.Concrete
{
    public class About : IEntity
    {
        public int Id { get; set; }
        public string Content1 { get; set; }
        public string Content2 { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
    }
}
