namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RequiredProdNameTest : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Name", c => c.String());
        }
    }
}
