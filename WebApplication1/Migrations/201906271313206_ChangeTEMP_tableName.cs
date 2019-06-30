namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTEMP_tableName : DbMigration
    {
        public override void Up()
        {
            RenameTable("TEMP_table", "Movies");
        }
        
        public override void Down()
        {
        }
    }
}
