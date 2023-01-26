using MiniBlog.Entities.Concretes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MiniBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            HasKey(c => c.Id);
            Property(c =>c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c =>c.Name).IsRequired().HasMaxLength(15);
            Property(c =>c.Description).IsRequired().HasMaxLength(250);
            Property(c => c.CreatedDate).IsRequired();
            ToTable("Categories");
        }
    }
}
