using MiniBlog.Entities.Concretes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MiniBlog.DataAccess.Concretes.EntityFramework.Mappings
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired().HasMaxLength(40);
            Property(c => c.Mail).IsRequired().HasMaxLength(40);
            Property(c => c.Text).IsRequired().HasMaxLength(700);
            Property(c => c.Date).IsRequired();
            Property(c => c.IsActive).IsRequired();

            HasRequired<Blog>(c => c.Blog).WithMany(b => b.Comments).HasForeignKey(c => c.BlogId).WillCascadeOnDelete(false);
            ToTable("Comments");
        }
    }
}
