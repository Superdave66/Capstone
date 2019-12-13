namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventsupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "DateTImeOfEvent", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "DateTImeOfEvent", c => c.DateTime(nullable: false));
        }
    }
}
