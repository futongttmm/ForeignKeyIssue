namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteColumnFromMovies : DbMigration
    {
        public override void Up()
        {
            DropColumn("Movies", "Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}
