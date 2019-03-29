using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IT_Shop.Models
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            Products = new List<Product>();
            isSelected = false;
        }
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool isSelected { get; set; }
        public List<Product> Products { get; set; }
        public IEnumerable<ManufactCatLink> ManufactCatLinks { get; set; }
    }
}