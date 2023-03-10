using MiniBlog.Entities.Concretes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

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
            Property(a => a.Title).IsRequired().HasMaxLength(20);
            Property(a => a.Email).IsRequired().HasMaxLength(50);
            Property(a => a.Password).IsRequired().HasMaxLength(50);
            ToTable("Authors");
        }
    }
}
