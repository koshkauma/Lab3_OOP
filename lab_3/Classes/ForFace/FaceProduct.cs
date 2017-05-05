using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes.ForFace
{
    public abstract class FaceProduct: CosmeticProduct
    {
        public enum SkinType
        {
            [Description("Комбинированная")]
            combo,
            [Description("Сухая")]
            dry,
            [Description("Нормальная")]
            normal,
            [Description("Жирная")]
            oily
        } //тип кожи
        public SkinType TypeOfSkin { get; set; }
        public enum TypeOfFinish
        {
            [Description("Матовое")]
            matt,
            [Description("Натуральное")]
            natural,
            [Description("Сияющее")]
            luminous
        } //тип финиша
        public TypeOfFinish Finish;

        public FaceProduct(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, SkinType TypeOfSkin, TypeOfFinish Finish):
            base(ProductName, Brand, PriceCategoryOfProduct, Color)
        {
            this.TypeOfSkin = TypeOfSkin;
            this.Finish = Finish;
        }

        public FaceProduct(int classIndex): base(classIndex)
        { }
    }
}
