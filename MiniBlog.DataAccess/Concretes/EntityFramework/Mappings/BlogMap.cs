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
    public class BlogMap : EntityTypeConfiguration<Blog>
    {
        public BlogMap()
        {
            HasKey(b => b.Id);
            Property(b => b.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(b => b.Title).IsRequired().HasMaxLength(100);
            Property(b => b.Content).IsRequired().HasColumnType("NVARCHAR(MAX)");
            Property(b => b.Date).IsRequired();
            Property(b => b.Image).IsRequired().HasMaxLength(300);
            Property(b => b.IsActive).IsRequired();

            HasRequired<Category>(b => b.Category).WithMany(c => c.Blogs).HasForeignKey(b => b.CategoryId).WillCascadeOnDelete(false);
            HasRequired<Author>(b => b.Author).WithMany(a => a.Blogs).HasForeignKey(b => b.AuthorId).WillCascadeOnDelete(false);
            ToTable("Blogs");
        }
    }
}
