namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetKeysToNewMoviesTable : DbMigration
    {
        public override void Up()
        {
            AddPrimaryKey("Movies", "Id");
            AddForeignKey("Movies", "Genre_Id", "Genres", "Id");
        }
        
        public override void Down()
        {
        }
    }
}
