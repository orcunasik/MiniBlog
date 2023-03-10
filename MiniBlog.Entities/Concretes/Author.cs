using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Entities.Concretes
{
    public class Author : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string About { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Title { get; set; }
        public ICollection<Blog> Blogs { get; set; }
    }
}
