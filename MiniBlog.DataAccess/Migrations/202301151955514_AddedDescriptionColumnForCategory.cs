namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDescriptionColumnForCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Description", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "Description");
        }
    }
}
