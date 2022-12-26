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
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).IsRequired().HasMaxLength(40);
            Property(c => c.Mail).IsRequired().HasMaxLength(40);
            Property(c => c.Text).IsRequired().HasMaxLength(700);

            HasRequired<Blog>(c => c.Blog).WithMany(b => b.Comments).HasForeignKey(c => c.BlogId).WillCascadeOnDelete(false);
            ToTable("Comments");
        }
    }
}
