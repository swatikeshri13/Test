using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngineApp
{
    public class ComputePriceEngine
    {
        public int ComputePrice(List<ProductModel> lstProductModel)
        {
            int resulatantPrice = 0;
            computePriceofSKUWithoutPromo(lstProductModel, ref resulatantPrice);
            return resulatantPrice;

        }
        private void computePriceofSKUWithoutPromo(List<ProductModel> productModelLst, ref int resulatantPrice)
        {
            foreach (var item in productModelLst)
            {
                if (!item.PromotionCodeApplied)
                {
                    resulatantPrice += item.ProductBasePrice * item.ProductCount;
                }
            }
        }
    }
}

