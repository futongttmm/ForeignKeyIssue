namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBirthdayToCustomersTable : DbMigration
    {
        public override void Up()
        {
            Sql("ALTER TABLE Customers DROP CONSTRAINT DF__Customers__Birth__403A8C7D");
            Sql("ALTER TABLE Customers ALTER COLUMN Birthday Date");
            //Sql("Update Customers Set Birthday = '1996-10-01' Where Id = 1");
            //Sql("Update Customers Set Birthday = null Where Id = 2");
            //Sql("Update Customers Set Birthday = null Where Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
