using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngineApp;

namespace PromoEngineAppTestProject
{
    [TestClass]
    public class ComputeEngineTest
    {
        [TestMethod]
        public void ComputeTest()
        {
            ComputePriceEngine objComputeEngine = new ComputePriceEngine();
            objComputeEngine.ComputePrice();
        }
    }
}
