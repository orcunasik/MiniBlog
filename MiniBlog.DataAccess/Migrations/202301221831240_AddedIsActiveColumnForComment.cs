namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIsActiveColumnForComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Comments", "IsActive");
        }
    }
}
