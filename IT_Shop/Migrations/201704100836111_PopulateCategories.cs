namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategories : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Name) VALUES ('Componente')");
            Sql("INSERT INTO Categories (Name) VALUES ('Periferice')");
            Sql("INSERT INTO Categories (Name) VALUES ('Telefoane')");
            Sql("INSERT INTO Categories (Name) VALUES ('Tablete')");
            Sql("INSERT INTO Categories (Name) VALUES ('Laptopuri')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE Id IN (1, 2, 3, 4, 5)");
        }
    }
}
