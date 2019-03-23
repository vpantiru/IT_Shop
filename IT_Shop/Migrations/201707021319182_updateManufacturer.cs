namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateManufacturer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Manufacturers", "isSelected", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Manufacturers", "isSelected");
        }
    }
}
