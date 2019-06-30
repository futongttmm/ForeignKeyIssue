namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribeToNewsletter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribeToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubscribeToNewsletter");
        }
    }
}
