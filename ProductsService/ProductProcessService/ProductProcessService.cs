using Product.DataService;
using Product.DataService.Contracts;
using Product.DataService.DataProvider;
using ProductProcessService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.ProcessService
{
    public class ProductProcessService: IProductProcessService
    {
        private IProductDataService _productDataService;
        private IProductDataProvider _productDataProvider;

        public ProductProcessService()
        {
            _productDataProvider = new ProductDataProvider();
            _productDataService = new ProductDataService(_productDataProvider);
        }

        public ProductProcessService(IProductDataService productDataService)
        {
            _productDataService = productDataService;
        }


        public List<Product.DomainEntity.ProductCategory> GetProduct()
        {
            return _productDataService.GetProducts();
        }
    }
}
