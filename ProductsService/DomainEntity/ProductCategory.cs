using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DomainEntity
{
    public class ProductCategory
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
        
    }
}
