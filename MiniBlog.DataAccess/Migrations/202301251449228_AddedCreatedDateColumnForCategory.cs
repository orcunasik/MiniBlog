namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCreatedDateColumnForCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CreatedDate");
        }
    }
}
