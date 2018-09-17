namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuggestionTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieSuggestions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        Suggestion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        { 
            DropTable("dbo.MovieSuggestions");
        }
    }
}
