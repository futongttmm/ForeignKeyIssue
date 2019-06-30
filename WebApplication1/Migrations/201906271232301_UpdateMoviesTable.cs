namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable("TEMP_table", t => new
            {
                Id = t.Int(nullable: false, identity: false),
                Name = t.String(nullable: false),
                Genre_Id = t.Int(nullable: false),
                Number = t.Int(),
                ReleaseDate = t.DateTime(),
                AddDate = t.DateTime()
            });
            Sql("Insert Into TEMP_table Select * From Movies");
        }
        
        public override void Down()
        {
        }
    }
}
