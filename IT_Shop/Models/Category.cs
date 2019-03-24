using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace IT_Shop.Models
{
    public class Category
    {
        public Category()
        {
            SubCategories = new List<Category>();
            Products = new List<Product>();
        }

        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public virtual Category Parent { get; set; }

        public int? ParentId { get; set; }    
        
        public virtual List<Category> SubCategories { get; set; }

        public virtual List<Product> Products { get; set; }

        public static implicit operator List<object>(Category v)
        {
            throw new NotImplementedException();
        }
    }
}