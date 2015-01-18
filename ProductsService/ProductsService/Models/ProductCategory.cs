using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsService.Models
{
    public class ProductCategory
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public Product [] Products { get; set; }
    }
}