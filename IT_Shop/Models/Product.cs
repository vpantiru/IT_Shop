using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IT_Shop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public Manufacturer Manufacturer{ get; set; }
        public int? ManufacturerId { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }
}