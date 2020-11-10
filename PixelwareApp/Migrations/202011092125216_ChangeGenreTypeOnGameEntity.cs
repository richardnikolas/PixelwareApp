namespace PixelwareApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreTypeOnGameEntity : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Games", "GenreId");
            AddForeignKey("dbo.Games", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            DropColumn("dbo.Games", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Games", "Genre", c => c.String());
            DropForeignKey("dbo.Games", "GenreId", "dbo.Genres");
            DropIndex("dbo.Games", new[] { "GenreId" });
        }
    }
}
