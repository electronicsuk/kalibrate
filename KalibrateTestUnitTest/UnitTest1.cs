using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KalibrateTest.Services;
using System.Linq;

namespace KalibrateTestUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]       
        public void ProduceExpectedOutputFromProductsLoadFromTextFileShouldSucceed()
        {
            ProductService srv = new ProductService();
            string  acutalResult = srv.ProductsLoadFromTextFile("Aged Brie 1 1").FirstOrDefault();
            Assert.AreEqual("Aged Brie 0 2", acutalResult);
        }
        
        [TestMethod]
        public void CheckIsNumberWorksAccordingly()
        {
            ProductService service = new ProductService();
            Assert.AreEqual(true, service.IsNumberic("12"));
            Assert.AreEqual(false, service.IsNumberic("two"));
        }


    }
}
