namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsActveColumnForBlogEntity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Blogs", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Blogs", "IsActive");
        }
    }
}
