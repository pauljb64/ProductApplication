using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Product.DataService.DataProvider;
using Product.DataService.Contracts;

namespace Product.DataService.Tests
{
    [TestClass]
    public class ProductDataServiceTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            IProductDataProvider productDataProvider = new ProductDataProvider();
            IProductDataService productDataService = new ProductDataService(productDataProvider);
            var result = productDataService.GetProducts();
            Assert.IsNotNull(result);
        }
    }
}
