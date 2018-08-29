namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateMoviesAddTitle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movie", "Title", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movie", "Title");
        }
    }
}
