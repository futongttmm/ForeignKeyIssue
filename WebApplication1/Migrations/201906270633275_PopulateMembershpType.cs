namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershpType : DbMigration
    {
        public override void Up()
        {
            

            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonth, DiscountRate) Values (0, 0, 0)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonth, DiscountRate) Values (30, 1, 10)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonth, DiscountRate) Values (90, 3, 15)");
            Sql("Insert Into MembershipTypes (SignUpFee, DurationInMonth, DiscountRate) Values (300, 12, 20)");
        }
        
        public override void Down()
        {
            Sql("Delete From MembershipTypes Where Id = 1");
            Sql("Delete From MembershipTypes Where Id = 2");
            Sql("Delete From MembershipTypes Where Id = 3");
            Sql("Delete From MembershipTypes Where Id = 4");
        }
    }
}
