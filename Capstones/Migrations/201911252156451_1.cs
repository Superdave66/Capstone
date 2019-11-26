namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventMakers", "ApplicationId", c => c.String(maxLength: 128));
            AddColumn("dbo.Tourists", "ApplicationId", c => c.String(maxLength: 128));
            CreateIndex("dbo.EventMakers", "ApplicationId");
            CreateIndex("dbo.Tourists", "ApplicationId");
            AddForeignKey("dbo.EventMakers", "ApplicationId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Tourists", "ApplicationId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tourists", "ApplicationId", "dbo.AspNetUsers");
            DropForeignKey("dbo.EventMakers", "ApplicationId", "dbo.AspNetUsers");
            DropIndex("dbo.Tourists", new[] { "ApplicationId" });
            DropIndex("dbo.EventMakers", new[] { "ApplicationId" });
            DropColumn("dbo.Tourists", "ApplicationId");
            DropColumn("dbo.EventMakers", "ApplicationId");
        }
    }
}
