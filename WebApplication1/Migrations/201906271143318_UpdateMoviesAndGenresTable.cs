namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesAndGenresTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.Genres", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Genres", "Number", c => c.Int(nullable: false));
            DropColumn("dbo.Movies", "Number");
        }
    }
}
