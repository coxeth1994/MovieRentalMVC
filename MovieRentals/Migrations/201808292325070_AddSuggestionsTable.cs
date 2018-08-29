namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSuggestionsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Suggestion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MovieSuggestion = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Suggestion", "CustomerId", "dbo.Customer");
            DropIndex("dbo.Suggestion", new[] { "CustomerId" });
            DropTable("dbo.Suggestion");
        }
    }
}
