namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedTitleEmailPasswordColumnsForAuthor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Email", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Authors", "Password", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Authors", "Title", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropIndex("dbo.Authors", "Email" );
            DropColumn("dbo.Authors", "Title");
            DropColumn("dbo.Authors", "Password");
            DropColumn("dbo.Authors", "Email");
        }
    }
}
