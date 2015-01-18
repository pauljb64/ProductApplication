using Product.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductProcessService.Contracts
{
    public interface IProductProcessService
    {
        List<ProductCategory> GetProduct();
    }
}
