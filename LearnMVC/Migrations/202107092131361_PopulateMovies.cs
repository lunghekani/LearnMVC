namespace LearnMVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) " +
                "VALUES ( 'Batman Begins', 1, 2005/06/24, 2005/06/24, 20)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Batman The Dark Knight', 1, 2008/07/25, 2008/07/25, 20)");
            Sql("INSERT INTO Movies ( Name, GenreId, DateAdded, ReleaseDate, NumberInStock) VALUES ( 'Batman The Dark Knight Rises', 1, 2012/07/27, 2012/07/27, 20)");
        }
        
        public override void Down()
        {
        }
    }
}
