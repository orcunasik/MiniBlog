using MiniBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.DataAccess.Concrete.EntityFramework.Mappings
{
    public class AboutMap : EntityTypeConfiguration<About>
    {
        public AboutMap()
        {
            HasKey(a => a.Id);
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.Content1).IsRequired().HasMaxLength(500);
            Property(a => a.Content2).IsRequired().HasMaxLength(500);
            Property(a => a.Image1).IsRequired().HasMaxLength(300);
            Property(a => a.Image2).IsRequired().HasMaxLength(300);
            ToTable("Abouts");
        }
    }
}
