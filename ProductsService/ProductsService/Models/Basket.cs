using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductsService.Models
{
    public class Basket
    {
        public Product [] products { get; set; }
        public double TotalAmount { get; set; }
    }
}