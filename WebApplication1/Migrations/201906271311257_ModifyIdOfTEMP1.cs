namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyIdOfTEMP1 : DbMigration
    {
        public override void Up()
        {
            Sql("Update TEMP_table Set Id = 3 Where Name = 'Hangover'");
            Sql("Update TEMP_table Set Id = 4 Where Name = 'Die Hard'");
            Sql("Update TEMP_table Set Id = 5 Where Name = 'The Terminator'");
            Sql("Update TEMP_table Set Id = 6 Where Name = 'Toy Story'");
            Sql("Update TEMP_table Set Id = 7 Where Name = 'Titanic'");
        }
        
        public override void Down()
        {
        }
    }
}
