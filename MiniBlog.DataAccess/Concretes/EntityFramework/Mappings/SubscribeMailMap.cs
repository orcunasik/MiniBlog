using MiniBlog.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class SubscribeMailMap : EntityTypeConfiguration<SubscribeMail>
    {
        public SubscribeMailMap()
        {
            HasKey(i => i.Id);
            Property(i => i.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(i => i.Mail).HasMaxLength(50);
            HasIndex(i => i.Mail).IsUnique();
            ToTable("SubscribeMails");
        }
    }
}
