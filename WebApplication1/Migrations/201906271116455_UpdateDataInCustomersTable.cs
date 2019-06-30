namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDataInCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set Birthday = 1990-01-01 Where Id = 2");
            Sql("Update Customers Set Birthday = 1990-01-01 Where Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
