namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EventMakers", "FirstName", c => c.String());
            AddColumn("dbo.EventMakers", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.EventMakers", "LastName");
            DropColumn("dbo.EventMakers", "FirstName");
        }
    }
}
