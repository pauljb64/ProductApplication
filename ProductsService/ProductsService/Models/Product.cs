using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsService.Models
{
    public class Product
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public string ProductCode { get; set; }
    }
}