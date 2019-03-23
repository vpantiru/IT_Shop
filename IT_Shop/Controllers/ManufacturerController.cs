using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IT_Shop.Models;
using System.Text;

namespace IT_Shop.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ViewManufacturers()
        {
            List<Manufacturer> man = new List<Manufacturer>();
            using (var ctx = new ApplicationDbContext())
            {
                man = ctx.Manufacturers.ToList().ConvertAll(m => new Manufacturer {Id = m.Id, Name = m.Name, Products = m.Products});
                return View(man);
            }            
        }

        //[HttpPost]
        //public string ViewManufacturers(IEnumerable<Manufacturer> Picked)
        //{
        //    if (Picked.Count(p => p.isSelected) == 0)
        //    {
        //        return "pula orase";
        //    }
        //    else
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        sb.Append("You picked"); 
        //        foreach (var p in Picked)
        //        {

        //            if (p.isSelected == true)
        //            {
        //                sb.Append(p.Name + ", ");
        //            }                  
        //        }
        //        return sb.ToString();
        //    }
        //}
    }
}