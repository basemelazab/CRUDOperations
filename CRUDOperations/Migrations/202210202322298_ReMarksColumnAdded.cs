namespace CRUDOperations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReMarksColumnAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ReMarks", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ReMarks");
        }
    }
}
