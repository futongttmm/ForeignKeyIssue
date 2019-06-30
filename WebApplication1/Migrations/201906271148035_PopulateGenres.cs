namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres Values ('Action')");
            Sql("Insert Into Genres Values ('Romance')");
            Sql("Insert Into Genres Values ('Family')");
            Sql("Insert Into Genres Values ('Comedy')");
        }
        
        public override void Down()
        {
        }
    }
}
