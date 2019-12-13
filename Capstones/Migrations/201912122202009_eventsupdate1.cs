namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventsupdate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Events", "KeyWord", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Events", "KeyWord");
        }
    }
}
