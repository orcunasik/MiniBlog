namespace MiniBlog.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedSubscribeMailEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SubscribeMails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Mail = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Mail, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.SubscribeMails", new[] { "Mail" });
            DropTable("dbo.SubscribeMails");
        }
    }
}
