using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes.ForEyes
{
    public class Eyeshadow: EyesProduct
    {
       public enum KindOfEyeshadow
       {
            [Description("Матовые")]
            matt,
            [Description("С блестками")]
            shimmer,
            [Description("Вельвет")]
            velvet,
            [Description("Сатиновые")]
            satin
       }
       public KindOfEyeshadow EyeshadowTexture { get; set; }
       public enum FormOfPackage
       {
            [Description("Жидкие тени")]
            liquid,
            [Description("Кремовые")]
            cream,
            [Description("Компактные")]
            compact,
            [Description("Рассыпчатые")]
            loose,
            [Description("В форме карандаша")]
            pencil,
            [Description("Запеченные")]
            baked
       }
       public FormOfPackage PackageType { get; set; }

       public Eyeshadow(string productName, string brand, PriceCategory priceCategoryOfProduct, Color Color, bool IsWaterpoof, string Effect, KindOfEyeshadow EyeshadowTexture,
       FormOfPackage PackageType) : base(productName, brand, priceCategoryOfProduct, Color, IsWaterpoof)
       {
            this.EyeshadowTexture = EyeshadowTexture;
            this.PackageType = PackageType;
       }

        public Eyeshadow(int classIndex): base(classIndex)
        { }
    }
}

