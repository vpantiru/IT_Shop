namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestManufacturers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "Manufacturer_Id", c => c.Int());
            CreateIndex("dbo.Products", "Manufacturer_Id");
            AddForeignKey("dbo.Products", "Manufacturer_Id", "dbo.Manufacturers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Manufacturer_Id", "dbo.Manufacturers");
            DropIndex("dbo.Products", new[] { "Manufacturer_Id" });
            DropColumn("dbo.Products", "Manufacturer_Id");
            DropTable("dbo.Manufacturers");
        }
    }
}
