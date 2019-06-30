namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable1 : DbMigration
    {
        public override void Up()
        {
            Sql("Alter Table Movies Drop Constraint DF__Movies__GenreId__4316F928");
            Sql("Alter Table Movies Drop Column GenreId");
            Sql("Insert Into Movies Values ('Hangover', 4, 5, '2006-11-04', '2016-05-04')");
            Sql("Insert Into Movies Values ('Die Hard', 1, 6, '2007-08-03', '2016-05-05')");
            Sql("Insert Into Movies Values ('The Terminator', 1, 7, '2008-06-22', '2016-05-06')");
            Sql("Insert Into Movies Values ('Toy Story', 3, 6, '2005-09-26', '2016-05-07')");
            Sql("Insert Into Movies Values ('Titanic', 2, 5, '2003-10-11', '2016-05-08')");
            Sql("Update Movies Set Genre_Id = 1, Number = 6, ReleaseDate = '2000-01-01', AddDate = '2018-09-09' Where Id = 1");
            Sql("Update Movies Set Genre_Id = 2, Number = 8, ReleaseDate = '2011-02-02', AddDate = '2019-06-06' Where Id = 2");
        }
        
        public override void Down()
        {
        }
    }
}
