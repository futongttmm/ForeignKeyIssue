namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayToCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("Update Customers Set Birthday = '10/01/1996' Where Name = 'TTMM'");
        }
        
        public override void Down()
        {
        }
    }
}
