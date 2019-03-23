namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestForParentId : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name, ParentId) VALUES ('Placi Video', 1)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE ParentId IN (1)");
        }
    }
}
