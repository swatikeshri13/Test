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
            var skuA = lstProductModel.Where(a => a.ProductSKUId == "A").FirstOrDefault();
            var skuB = lstProductModel.Where(a => a.ProductSKUId == "B").FirstOrDefault();
            var skuC = lstProductModel.Where(a => a.ProductSKUId == "C").FirstOrDefault();
            var skuD = lstProductModel.Where(a => a.ProductSKUId == "D").FirstOrDefault();
           
            if (skuA != null && apply3ACoupon(skuA, ref resulatantPrice))
                lstProductModel.Where(a => a.ProductSKUId == "A").FirstOrDefault().PromotionCodeApplied = true;
            if (skuB != null && apply3BCoupon(skuB, ref resulatantPrice))
                lstProductModel.Where(a => a.ProductSKUId == "B").FirstOrDefault().PromotionCodeApplied = true;
            if (skuC != null && skuD != null && applyCDCoupon(skuC, skuD, ref resulatantPrice))
            {
                lstProductModel.Where(a => a.ProductSKUId == "C").FirstOrDefault().PromotionCodeApplied = true;
                lstProductModel.Where(a => a.ProductSKUId == "D").FirstOrDefault().PromotionCodeApplied = true;
            }
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

        private bool applyCDCoupon(ProductModel productModelC, ProductModel productModelD, ref int resulatantPrice)
        {
            if (productModelC.ProductCount != 0 && productModelD.ProductCount != 0)
            {
                if (productModelC.ProductCount <= productModelD.ProductCount)
                {
                    resulatantPrice += ((productModelD.ProductCount / productModelC.ProductCount) * 30) + ((productModelD.ProductCount % productModelC.ProductCount) * productModelD.ProductBasePrice)
            ;
                }
                else
                {
                    resulatantPrice += ((productModelC.ProductCount / productModelD.ProductCount) * 30) + ((productModelC.ProductCount % productModelD.ProductCount) * productModelC.ProductBasePrice)
    ;
                }
            }

            productModelC.PromotionCodeApplied = true;
            productModelD.PromotionCodeApplied = true;

            return false;
        }

        private bool apply3BCoupon(ProductModel productModelB, ref int resulatantPrice)
        {
            if (productModelB.ProductCount >= 2)

            {

                resulatantPrice += ((productModelB.ProductCount / 2) * 45) + (productModelB.ProductBasePrice * (productModelB.ProductCount % 2));
                return true;
            }
            return false;
        }

        private bool apply3ACoupon(ProductModel productModel3A, ref int resulatantPrice)
        {
            if (productModel3A.ProductCount >= 3)
            {
                resulatantPrice += ((productModel3A.ProductCount / 3) * 130) + (productModel3A.ProductBasePrice * (productModel3A.ProductCount % 3));
                productModel3A.PromotionCodeApplied = true;
            }
            return productModel3A.PromotionCodeApplied;
            //throw new NotImplementedException();
        }
    }
}

