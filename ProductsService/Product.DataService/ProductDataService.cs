using Product.DataService.Contracts;
using Product.DomainEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.DataService
{
    public class ProductDataService : IProductDataService
    {
        private IProductDataProvider _ProductDataProvider;

        public ProductDataService(IProductDataProvider productDataProvider)
        {
            _ProductDataProvider = productDataProvider;
        }
        
        
        
        public List<DomainEntity.ProductCategory> GetProducts()
        {
           List<ProductCategory> productCategorys = new List<ProductCategory>();
            productCategorys.Add(new ProductCategory { Category = "Unisex Clothing", Description = "Clothing for boys and girls", Products = new List<DomainEntity.Product> { new DomainEntity.Product { Name = "Tie", Price = (double)2.5, ProductCode = "UCL001" }, new DomainEntity.Product { Name = "Badge", Price = (double)0.5, ProductCode = "UCL002" }, new DomainEntity.Product { Name = "Backpack", Price = (double)8.99, ProductCode = "UCL003" }} });
            productCategorys.Add(new ProductCategory { Category = "Boys Clothing", Description = "Clothing for boys", Products = new List<DomainEntity.Product> { new DomainEntity.Product { Name = "Trousers", Price = (double)5.99, ProductCode = "BCL001" }, new DomainEntity.Product { Name = "Shirt", Price = (double)4.99, ProductCode = "BCL002" }, new DomainEntity.Product { Name = "Blazer", Price = (double)12.99, ProductCode = "BCL003" }, new DomainEntity.Product { Name = "Sports shorts", ProductCode = "BCL004" }, new DomainEntity.Product { Name = "Sports Socks", Price = (double)2.99, ProductCode = "BCL005" }, new DomainEntity.Product { Name = "Sports top", Price = (double)7.99, ProductCode = "BCL006" } } });
            productCategorys.Add(new ProductCategory { Category = "Girls Clothing", Description = "Clothing for girls", Products = new List<DomainEntity.Product> { new DomainEntity.Product { Name = "Trousers", Price = (double)5.99, ProductCode = "GCL001" }, new DomainEntity.Product { Name = "Skirt", Price = (double)4.99, ProductCode = "GCL002" }, new DomainEntity.Product { Name = "Shirt", Price = (double)4.99, ProductCode = "GCL003" }, new DomainEntity.Product { Name = "Blazer",Price = (double)4.99, ProductCode = "BCL004" },  } });
            productCategorys.Add(new ProductCategory { Category = "Stationery", Description = "Stationery products", Products = new List<DomainEntity.Product> { new DomainEntity.Product { Name = "A4 Pad", Price = (double)2.5, ProductCode = "STA001" }, new DomainEntity.Product { Name = "A5 Pad", Price = (double)1.75, ProductCode = "STA002" }, new DomainEntity.Product { Name = "Blue biro pen", Price = (double)0.3, ProductCode = "STA003" }, new DomainEntity.Product { Name = "Blackj Biro pen", Price = (double) 0.3, ProductCode = "STA004" } } });
            return productCategorys;
        }
    }
}
   