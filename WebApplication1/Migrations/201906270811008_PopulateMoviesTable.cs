namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Movies Values ('Shrek!') ");
            Sql("Insert Into Movies Values ('Love!') ");
        }
        
        public override void Down()
        {
        }
    }
}
