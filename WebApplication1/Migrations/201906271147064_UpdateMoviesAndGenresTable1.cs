namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesAndGenresTable1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "ReleaseDate", c => c.DateTime());
            AddColumn("dbo.Movies", "AddDate", c => c.DateTime());
            DropColumn("dbo.Genres", "ReleaseDate");
            DropColumn("dbo.Genres", "AddDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "AddDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Genres", "ReleaseDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Movies", "AddDate");
            DropColumn("dbo.Movies", "ReleaseDate");
        }
    }
}
