using Product.DataService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataService.DataProvider
{
    public class ProductDataProvider: IProductDataProvider
    {
        public List<DomainEntity.ProductCategory> Read()
        {
            return new List<DomainEntity.ProductCategory>();
        }
    }
}
