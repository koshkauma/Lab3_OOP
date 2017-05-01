using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes
{
    public class Lipstick: LipProduct
    {
        public enum TypeOfPackege { jar, palette, stick, cushion}
        public TypeOfPackege PackageType { get; set; }
        public enum TypeOfFinish { matt, sheer, metallized, cream, withShimmer}
        public TypeOfFinish Finish { get; set; }

        public Lipstick(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, string Aromatizer,
        TypeOfPackege PackageType, TypeOfFinish Finish) : base(ProductName, Brand, PriceCategoryOfProduct, Color, Aromatizer)
        {
            this.PackageType = PackageType;
            this.Finish = Finish;
        }
    }
}
