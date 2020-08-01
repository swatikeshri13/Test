using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class ProductModel
    {
        public int ProductID { get; set; }

        public string ProductName { get; set; }

        public int ProductBasePrice { get; set; }

        public string ProductSKUId { get; set; }

        public int ProductCount { get; set; }

        public bool PromotionCodeApplied { get; set; }
    }
}
