using IT_Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_Shop.Views.ViewModels
{
    public class ProductViewModel
    {
        public string Name { get; set; }

        public int Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }

        public int Manufacturer { get; set; }
        public IEnumerable<Manufacturer> Manufacturers { get; set; }
    }
}