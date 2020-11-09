namespace PixelwareApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'RPG')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Indie')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Simulation')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Massive Multiplayer')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'Strategy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Sports')");
        }
        
        public override void Down()
        {
        }
    }
}
