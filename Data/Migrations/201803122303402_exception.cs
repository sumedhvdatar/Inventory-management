namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class exception : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.User", "EmailId", c => c.String());
            AddColumn("dbo.User", "Role", c => c.String());
            AddColumn("dbo.User", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.User", "IsActive");
            DropColumn("dbo.User", "Role");
            DropColumn("dbo.User", "EmailId");
        }
    }
}
