namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tourists", "Interests", c => c.String());
            DropColumn("dbo.Tourists", "Interest");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tourists", "Interest", c => c.String());
            DropColumn("dbo.Tourists", "Interests");
        }
    }
}
