using ProductsService.Models;
using Product.ProcessService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net;


namespace ProductsService.Controllers
{
    public class ProductsController : ApiController
    {
        
        private Product.ProcessService.ProductProcessService _productProcessService;

        public ProductsController()
        {
            _productProcessService = new Product.ProcessService.ProductProcessService();
        }


        private ProductCategory[] GetProductCategories()
        {
            List<Product.DomainEntity.ProductCategory> productCategory = _productProcessService.GetProduct();
            List<ProductCategory> modelProductCatrgory = new List<ProductCategory>();
            foreach (var item in productCategory)
            {

                List<Models.Product> modelProduct = new List<Models.Product>();
                foreach (var product in item.Products)
                {
                    modelProduct.Add(new Models.Product{Name = product.Name, UnitPrice = product.Price, ProductCode = product.ProductCode});
                }
                modelProductCatrgory.Add(new Models.ProductCategory { Category = item.Category, Products = modelProduct.ToArray() });
            }
            return modelProductCatrgory.ToArray();

        }

        public IEnumerable<ProductCategory> GetProducts()
        {
            var products = GetProductCategories();
            if (products == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return products;
        }



    }
}
