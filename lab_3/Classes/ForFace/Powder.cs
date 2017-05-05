using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes.ForFace
{
    public class Powder: FaceProduct
    {
        public enum TypeOfPackage
        {
            [Description("Рассыпчатая")]
            loose,
            [Description("Компактная")]
            compact
        }
        public TypeOfPackage Package { get; set; }
        public bool isContainTalc { get; set; }

        public Powder(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, SkinType TypeOfSkin, TypeOfFinish Finish, TypeOfPackage Package, bool isContainTalc) :
                base(ProductName, Brand, PriceCategoryOfProduct, Color, TypeOfSkin, Finish)
        {
            this.Package = Package;
            this.isContainTalc = isContainTalc;
        }


        public Powder(int classIndex): base(classIndex)
        { }

    }
}
