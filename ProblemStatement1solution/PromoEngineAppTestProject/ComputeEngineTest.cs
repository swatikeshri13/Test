using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineApp;
using System.Collections.Generic;

namespace PromoEngineAppTestProject
{
    [TestClass]
    public class ComputeEngineTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            ComputePriceEngine objComputeEngine = new ComputePriceEngine();
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "A", ProductBasePrice = 50 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "B", ProductBasePrice = 30 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "C", ProductBasePrice = 20 });
            //lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "D", ProductBasePrice = 0 });
            int result = objComputeEngine.ComputePrice(lstProducts);
            Assert.AreEqual(result, 100);
        }

        [TestMethod]
        public void ComputeTest2()
        {
            ComputePriceEngine objComputeEngine = new ComputePriceEngine();
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts.Add(new ProductModel() { ProductCount = 5, ProductSKUId = "A", ProductBasePrice = 50 });
            lstProducts.Add(new ProductModel() { ProductCount = 5, ProductSKUId = "B", ProductBasePrice = 30 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "C", ProductBasePrice = 20 });
            //lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "D", ProductBasePrice = 0 });

            int result = objComputeEngine.ComputePrice(lstProducts);
            Assert.AreEqual(result, 370);
        }

        [TestMethod]
        public void ComputeTest3()
        {
            ComputePriceEngine objComputeEngine = new ComputePriceEngine();
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts.Add(new ProductModel() { ProductCount = 3, ProductSKUId = "A", ProductBasePrice = 50 });
            lstProducts.Add(new ProductModel() { ProductCount = 5, ProductSKUId = "B", ProductBasePrice = 30 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "C", ProductBasePrice = 20 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "D", ProductBasePrice = 15 });
           
            int result = objComputeEngine.ComputePrice(lstProducts);
            Assert.AreEqual(result, 280);

        }
    }
}
