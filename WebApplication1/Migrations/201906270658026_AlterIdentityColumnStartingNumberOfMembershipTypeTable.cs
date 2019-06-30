namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterIdentityColumnStartingNumberOfMembershipTypeTable : DbMigration
    {
        public override void Up()
        {
            //Sql("DBCC CHECKIDENT ('MembershipTypes', RESEED, 1)");
            DropForeignKey("dbo.Customers", "Membership_Id", "dbo.MembershipTypes");
            DropIndex("dbo.Customers", new[] { "Membership_Id" });
            DropColumn("dbo.Customers", "Membership_Id");
            DropColumn("dbo.Customers", "MembershipTypeId");
            DropTable("dbo.MembershipTypes");

            CreateTable(
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Int(nullable: false, identity: false),
                    SignUpFee = c.Short(nullable: false),
                    DurationInMonth = c.Byte(nullable: false),
                    DiscountRate = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AddColumn("dbo.Customers", "MembershipTypeId", c => c.Byte(nullable: false));
            AddColumn("dbo.Customers", "Membership_Id", c => c.Int());
            CreateIndex("dbo.Customers", "Membership_Id");
            AddForeignKey("dbo.Customers", "Membership_Id", "dbo.MembershipTypes", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
