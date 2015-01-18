using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DomainEntity
{
    public class Basket
    {
        public List<Product> products { get; set; }
        public double TotalAmount { get; set; }
    }
}
