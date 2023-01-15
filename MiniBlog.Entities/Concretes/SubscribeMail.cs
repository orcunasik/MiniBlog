using MiniBlog.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Entities.Concretes
{
    public class SubscribeMail : IEntity
    {
        public int Id { get; set; }
        public string Mail{ get; set; }
    }
}
