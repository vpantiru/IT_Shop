using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_Shop.Models;
using System.Text;

namespace IT_Shop.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
       
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            List<Category> cat = new List<Category>();
            using (var ctx = new ApplicationDbContext())
            {
                cat =
                    ctx.Categories.ToList()
                        .ConvertAll(t => new Category {Id = t.Id, Name = t.Name, ParentId = t.ParentId, Parent = t.Parent, SubCategories = t.SubCategories});
            }
            return View("~/Views/Shared/_Menus.cshtml", cat);
        }

        public ActionResult ViewProducts(string CategoryName, string SubcategoryName)
        {
            List<Product> prod = new List<Product>();
            using (var ctx = new ApplicationDbContext())
            {
                prod = ctx.Products.Where(t => t.Category.Name == SubcategoryName.Replace("_", " ")).Include(t => t.Category.Parent).ToList().ConvertAll(t => new Product {Id = t.Id, CategoryId = t.CategoryId, Category = t.Category, Name = t.Name});
            }
            return View(prod);
        }

        [HttpGet]
        public ActionResult ViewCategoryManufacturers(string CategoryName, string SubcategoryName)
        {
            List<Manufacturer> man = new List<Manufacturer>();
            using (var ctx = new ApplicationDbContext())
            {
                man = ctx.Manufacturers.Where(t => t.Products.Any(c => c.Category.Name == SubcategoryName.Replace("_", " "))).ToList();
            }
            return View("ViewCategoryManufacturers", man);
        }

        [HttpPost]
        public string ViewCategoryManufacturers(IEnumerable<Manufacturer> Picked)
        {
            if (Picked.Count(p => p.isSelected) == 0)
            {
                return "pula alegeri";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("You picked ");
                foreach (var p in Picked)
                {

                    if (p.isSelected == true)
                    {
                        sb.Append(p.Name + ", ");
                    }
                }
                sb.Remove(sb.ToString().LastIndexOf(","), 1);
                return sb.ToString();
            }
        }

    }
}