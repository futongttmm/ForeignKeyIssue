namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DropForeignKeyOfMovies : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("Movies", "FK_Movies_Genres_Genre_Id");
        }
        
        public override void Down()
        {
        }
    }
}
