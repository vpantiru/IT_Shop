using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_Shop.Models;

namespace IT_Shop.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        public ProductController()
        {
                var context = new ApplicationDbContext();
        }
            

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewProductDetails(string CategoryName, string SubcategoryName, string ProductName)
        {
            Product prod;
            using (var ctx = new ApplicationDbContext())
            {
                var prodDB = ctx.Products.SingleOrDefault(p => p.Name == ProductName.Replace("_", " "));
                prod = new Product
                {
                    Id = prodDB.Id,
                    Name = prodDB.Name,
                    CategoryId = prodDB.CategoryId,                
                    Category = prodDB.Category
                };
            }
                return View(prod);
        }
    }
}