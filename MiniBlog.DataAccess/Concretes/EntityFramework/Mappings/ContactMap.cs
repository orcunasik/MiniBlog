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
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.FirstName).IsRequired().HasMaxLength(40);
            Property(c => c.LastName).IsRequired().HasMaxLength(40);
            Property(c => c.Mail).IsRequired().HasMaxLength(40);
            Property(c => c.Message).IsRequired().HasMaxLength(300);
            Property(c => c.Subject).IsRequired().HasMaxLength(25);
            Property(c => c.Date).IsRequired();
            ToTable("Contacts");
        }
    }
}
