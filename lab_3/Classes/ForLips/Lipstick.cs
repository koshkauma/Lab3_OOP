using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes
{
    public class Lipstick: LipProduct
    {
        public enum TypeOfPackage
        {
            [Description("Баночка")]
            jar,
            [Description("Палетка")]
            palette,
            [Description("Стик")]
            stick,
            [Description("Кушон")]
            cushion
        }
        public TypeOfPackage PackageType { get; set; }
        public enum TypeOfFinish
        {
            [Description("Матовый")]
            matt,
            [Description("Оттеночный")]
            sheer,
            [Description("Металлик")]
            metallized,
            [Description("Кремовый")]
            cream,
            [Description("Сияющий (блестки)")]
            withShimmer
        }
        public TypeOfFinish Finish { get; set; }

        public Lipstick(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, string Aromatizer,
        TypeOfPackage PackageType, TypeOfFinish Finish) : base(ProductName, Brand, PriceCategoryOfProduct, Color, Aromatizer)
        {
            this.PackageType = PackageType;
            this.Finish = Finish;
        }


        public Lipstick(int classIndex): base(classIndex)
        { }
    }
}
