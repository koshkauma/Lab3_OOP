using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForFace
{
    public class Powder: FaceProduct
    {
        
        public enum TypeOfPackage { loose, compact }
        public TypeOfPackage Package { get; set; }

        public Powder(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, SkinType TypeOfSkin, TypeOfFinish Finish, TypeOfPackage Package) :
                base(ProductName, Brand, PriceCategoryOfProduct, Color, TypeOfSkin, Finish)
        {
            this.Package = Package;
        }
        
    }
}
