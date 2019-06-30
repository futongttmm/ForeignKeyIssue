namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypesName : DbMigration
    {
        public override void Up()
        {
            Sql("Update MembershipTypes Set Name = 'Pay as you go' Where Id = 1");
            Sql("Update MembershipTypes Set Name = 'Monthly' Where Id = 2");
            Sql("Update MembershipTypes Set Name = 'Seasonly' Where Id = 3");
            Sql("Update MembershipTypes Set Name = 'Annualy' Where Id = 4");
        }
        
        public override void Down()
        {
        }
    }
}
