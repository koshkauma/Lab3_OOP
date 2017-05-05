using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForEyes
{
    public abstract class EyesProduct: CosmeticProduct
    {
       public bool IsWaterproof { get; set; }

       public EyesProduct(string productName, string brand, PriceCategory priceCategoryOfProduct, Color Color, bool isWaterpoof) : base(productName, brand, priceCategoryOfProduct, Color)
       {
            this.IsWaterproof = IsWaterproof;
       }


        public EyesProduct(int classIndex): base(classIndex)
        { }

    }
}
