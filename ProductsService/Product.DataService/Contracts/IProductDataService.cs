using Product.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataService.Contracts
{
    public interface IProductDataService
    {
        List<ProductCategory> GetProducts();
    }
}
