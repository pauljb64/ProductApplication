using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.DataService.Contracts;
using Product.DataService;
using Product.DataService.DataProvider;
using ProductProcessService.Contracts;

namespace Product.ProcessService.Tests
{
    [TestClass]
    public class ProductProcessServiceTests
    {
        [TestMethod]
        public void CallsProductDataService()
        {
            IProductDataProvider productDataProvider = new ProductDataProvider();
            IProductDataService productDataService = new ProductDataService(productDataProvider);
            IProductProcessService productProcessService = new ProductProcessService(productDataService);
            var result = productProcessService.GetProduct();
            Assert.IsNotNull(result);
        }
    }
}
