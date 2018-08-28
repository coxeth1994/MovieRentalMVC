namespace MovieRentals.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TableUpdates : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Transaction", name: "Customer_Id", newName: "CustomerId");
            RenameIndex(table: "dbo.Transaction", name: "IX_Customer_Id", newName: "IX_CustomerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Transaction", name: "IX_CustomerId", newName: "IX_Customer_Id");
            RenameColumn(table: "dbo.Transaction", name: "CustomerId", newName: "Customer_Id");
        }
    }
}
