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
            objComputeEngine.ComputePrice();
            Console.ReadKey();
        }
    }
}
