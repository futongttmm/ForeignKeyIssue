namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayToCustomersTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set Birthday = '1996-10-01' Where Id = 1");
            Sql("Update Customers Set Birthday = null Where Id = 2");
            Sql("Update Customers Set Birthday = null Where Id = 3");
        }

        public override void Down()
        {
        }
    }
}
