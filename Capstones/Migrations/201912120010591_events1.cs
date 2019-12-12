namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class events1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        DateTImeOfEvent = c.DateTime(nullable: false),
                        Attendees = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Events");
        }
    }
}
