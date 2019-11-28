namespace Capstones.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedstatesearchtotourist : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tourists", "SelectedState", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tourists", "SelectedState");
        }
    }
}
