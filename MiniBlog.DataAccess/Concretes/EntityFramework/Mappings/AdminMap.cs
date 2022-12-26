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
    public class AdminMap : EntityTypeConfiguration<Admin>
    {
        public AdminMap()
        {
            HasKey(a => a.Id);
            Property(a => a.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(a => a.UserName).IsRequired().HasMaxLength(10);
            Property(a => a.Password).IsRequired().HasMaxLength(25);
            ToTable("Admins");
        }
    }
}
