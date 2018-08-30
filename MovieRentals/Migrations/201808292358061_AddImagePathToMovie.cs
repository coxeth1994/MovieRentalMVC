namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImagePathToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "ImagePath", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "ImagePath");
        }
    }
}
