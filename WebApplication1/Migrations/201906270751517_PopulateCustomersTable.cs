namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomersTable : DbMigration
    {
        public override void Up()
        {
            //Sql("SET IDENTITY_INSERT Customers ON");
            Sql("Insert Into Customers Values ('John Smith', 'false', 1)");
            //Sql("SET IDENTITY_INSERT Customers Off");

            //Sql("SET IDENTITY_INSERT Customers ON");
            Sql("Insert Into Customers Values ('Mark Walliam', 'true', 3)");
            //Sql("SET IDENTITY_INSERT Customers Off");
        }
        
        public override void Down()
        {
        }
    }
}
