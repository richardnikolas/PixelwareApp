namespace PixelwareApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPublisherToGameModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Games", "PublisherId", c => c.Byte(nullable: false));
            AddColumn("dbo.Games", "Publisher_Id", c => c.Int());
            CreateIndex("dbo.Games", "Publisher_Id");
            AddForeignKey("dbo.Games", "Publisher_Id", "dbo.Publishers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "Publisher_Id", "dbo.Publishers");
            DropIndex("dbo.Games", new[] { "Publisher_Id" });
            DropColumn("dbo.Games", "Publisher_Id");
            DropColumn("dbo.Games", "PublisherId");
        }
    }
}
