using MiniBlog.DataAccess.Concretes.EntityFramework.Mappings;
using MiniBlog.Entities.Concretes;
using System.Data.Entity;

namespace MiniBlog.DataAccess.Concretes.EntityFramework.Contexts
{
    public class MiniBlogContext : DbContext
    {
        public MiniBlogContext() : base("name=MiniBlogDbConnectionString")
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminMap());
            modelBuilder.Configurations.Add(new AuthorMap());
            modelBuilder.Configurations.Add(new AboutMap());
            modelBuilder.Configurations.Add(new BlogMap());
            modelBuilder.Configurations.Add(new CategoryMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new ContactMap());
        }
    }
}
