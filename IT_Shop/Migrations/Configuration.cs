using System.Collections.Generic;
using IT_Shop.Models;

namespace IT_Shop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<IT_Shop.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(IT_Shop.Models.ApplicationDbContext context)
        {
            var items = new List<Category>() { new Category() { Name = "Coolere", ParentId = 1 },
                                               new Category() { Name = "HDD", ParentId = 1 },
                                               new Category() { Name = "Memorii", ParentId = 1 },
                                               new Category() { Name = "Placi de baza", ParentId = 1 },
                                               new Category() { Name = "Mouse", ParentId = 2 },
                                               new Category() { Name = "Camere Web", ParentId = 2 },
                                               new Category() { Name = "Casti", ParentId = 2 },
                                               new Category() { Name = "Full HD", ParentId = 5 },
                                               new Category() { Name = "4k", ParentId = 5 },
                                               new Category() { Name = "Android", ParentId = 3 },
                                               new Category() { Name = "iOS", ParentId = 3 },
                                               new Category() { Name = "Tastaturi", ParentId = 2 }};
            var manufact = new List<Manufacturer>
            {
                                               new Manufacturer() {Name = "Asus"},
                                               new Manufacturer() {Name = "Sapphire"},
                                               new Manufacturer() {Name = "Intel"},
                                               new Manufacturer() {Name = "Kingston"},
                                               new Manufacturer() {Name = "Asus"},
                                               new Manufacturer() {Name = "Logitech"},
                                               new Manufacturer() {Name = "Sennheiser"},
                                               new Manufacturer() {Name = "Samsung"},
                                               new Manufacturer() {Name = "LG"},
                                               new Manufacturer() {Name = "Razer"},
                                               new Manufacturer() {Name = "Western Digital"},
                                               new Manufacturer() {Name = "Noctua"}};

            var products = new List<Product>() { new Product() { Name = "Asus Nvidia GTX 1080", CategoryId = 9, ManufacturerId = 1},
                                               new Product() { Name = "Intel I7 7700K", CategoryId = 7, ManufacturerId = 3 },
                                               new Product() { Name = "Sapphire AMD Radeon 480", CategoryId = 9, ManufacturerId = 2 },
                                               new Product() { Name = "Kingston RAM bun", CategoryId = 15, ManufacturerId = 4 },
                                               new Product() { Name = "Asus M5A977", CategoryId = 12, ManufacturerId = 1 },                                               
                                               new Product() { Name = "Logitech bun", CategoryId = 23, ManufacturerId = 5 },
                                               new Product() { Name = "Sennheiser HD 650", CategoryId = 24, ManufacturerId = 6 },
                                               new Product() { Name = "Full HD", CategoryId = 5, ManufacturerId = 8 },
                                               new Product() { Name = "TV Smeker", CategoryId = 26, ManufacturerId = 7 },
                                               new Product() { Name = "Samsung Galaxy S8", CategoryId = 27, ManufacturerId = 7 },
                                               new Product() { Name = "Razer Deathadder", CategoryId = 22, ManufacturerId = 9 },
                                               new Product() { Name = "Western Digital Blue 1TB", CategoryId = 19, ManufacturerId = 10 },
                                               new Product() { Name = "Noctua", CategoryId = 21, ManufacturerId = 11 },
                                               new Product() { Name = "Logitech K70 RGB", CategoryId = 29, ManufacturerId = 5 }};

            foreach (var j in items)
            {
                context.Categories.AddOrUpdate(c => c.Name, j);
                context.SaveChanges();
            }          
            var cat = context.Categories.ToList();

            foreach (var i in cat)
            {
                if (i.ParentId != null)
                {
                    Category par = context.Categories.SingleOrDefault(p => p.Id == i.ParentId);                    
                    par.SubCategories.Add(i);                    
                }
            }
            context.SaveChanges();

            foreach (var k in manufact)
            {
                context.Manufacturers.AddOrUpdate(m => m.Name, k);
                context.SaveChanges();
            }

            foreach (var i in products)
            {
                context.Products.AddOrUpdate(p => p.Name, i);
                context.SaveChanges();
            }

            var prod = context.Products.ToList();
            foreach (var i in prod)
            {
                    Manufacturer brand = context.Manufacturers.SingleOrDefault(p => p.Id == i.ManufacturerId);
                   
                if (brand != null) brand.Products.Add(i);
                //context.Categories.AddOrUpdate(c => c.Name, i);                
            }
            context.SaveChanges();
        
            var sub = context.Products.ToList();         
            
            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
