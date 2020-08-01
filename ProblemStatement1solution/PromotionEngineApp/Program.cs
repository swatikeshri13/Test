using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
   public class Program
    {
        static void Main(string[] args)
        {
            ComputePriceEngine objComputeEngine = new ComputePriceEngine();
            List<ProductModel> lstProducts = new List<ProductModel>();
            lstProducts.Add(new ProductModel() { ProductCount = 3, ProductSKUId = "A", ProductBasePrice = 50 });
            lstProducts.Add(new ProductModel() { ProductCount = 5, ProductSKUId = "B", ProductBasePrice = 30 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "C", ProductBasePrice = 20 });
            lstProducts.Add(new ProductModel() { ProductCount = 1, ProductSKUId = "D", ProductBasePrice = 15 });

            objComputeEngine.ComputePrice(lstProducts);
            Console.ReadKey();
        }
    }
}
