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
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            HasKey(a => a.Id);
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Name).IsRequired().HasMaxLength(20);
            Property(a => a.About).IsRequired().HasMaxLength(100);
            Property(a => a.Image).IsRequired().HasMaxLength(300);
            ToTable("Authors");
        }
    }
}
