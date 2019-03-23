namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateManufacturers : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Products", name: "Manufacturer_Id", newName: "ManufacturerId");
            RenameIndex(table: "dbo.Products", name: "IX_Manufacturer_Id", newName: "IX_ManufacturerId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Products", name: "IX_ManufacturerId", newName: "IX_Manufacturer_Id");
            RenameColumn(table: "dbo.Products", name: "ManufacturerId", newName: "Manufacturer_Id");
        }
    }
}
