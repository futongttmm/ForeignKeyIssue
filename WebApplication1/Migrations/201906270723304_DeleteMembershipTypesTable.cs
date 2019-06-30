namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMembershipTypesTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Membership_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "Membership_Id" });
            DropColumn("dbo.Customers", "Membership_Id");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");
        }
        
        public override void Down()
        {
        }
    }
}
