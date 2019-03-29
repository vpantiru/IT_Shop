using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IT_Shop.Models
{
    public class ManufactCatLink
    {
        public int ManufactCatLinkID { get; set; }
        public int ManufacturerID { get; set; }
        public int CategoryID { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Category Category { get; set; }
    }
}