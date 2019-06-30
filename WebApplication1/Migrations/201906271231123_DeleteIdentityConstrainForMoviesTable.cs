namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteIdentityConstrainForMoviesTable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("Movies", "Id", c => c.Int(nullable: false, identity: false));
        }
        
        public override void Down()
        {
        }
    }
}
