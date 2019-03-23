namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reverseGood : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Categories", "testNr");
            DropColumn("dbo.Categories", "Number");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Number", c => c.Int(nullable: false));
            AddColumn("dbo.Categories", "testNr", c => c.Int());
        }
    }
}
