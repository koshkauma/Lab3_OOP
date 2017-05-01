using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForFace
{
    public class FaceProduct: CosmeticProduct
    {
        public enum SkinType { combo, dry, normal, oily} //тип кожи
        public SkinType TypeOfSkin { get; set; }
        public enum TypeOfFinish { matt, natural, luminous } //тип финиша
        public TypeOfFinish Finish;

        public FaceProduct(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, SkinType TypeOfSkin, TypeOfFinish Finish):
            base(ProductName, Brand, PriceCategoryOfProduct, Color)
        {
            this.TypeOfSkin = TypeOfSkin;
            this.Finish = Finish;
        }
    }
}
