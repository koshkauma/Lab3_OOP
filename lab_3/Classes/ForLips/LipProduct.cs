using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace lab_3.Classes
{
    public abstract class LipProduct: CosmeticProduct
    {
        public string Aromatizer { get; set; }

        public LipProduct(string ProductName,
            string Brand, PriceCategory PriceCategoryOfProduct,
            Color Color, string Aromatizer) : base(ProductName, Brand, PriceCategoryOfProduct, Color)
        {
            this.Aromatizer = Aromatizer;
            this.Color = Color;
        }


        public LipProduct(int classIndex): base(classIndex)
        { }
    }
}
