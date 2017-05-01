using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForEyes
{
    public class Eyeshadow: EyesProduct
    {
       public enum KindOfEyeshadow { matt, shimmer, velvet, satin}
       public KindOfEyeshadow EyeshadowTexture { get; set; }
       public enum FormOfPackage { liquid, cream, compact, loose, palette, pencil, baked}
       public FormOfPackage PackageType { get; set; }

       public Eyeshadow(string productName, string brand, PriceCategory priceCategoryOfProduct, Color Color, bool IsWaterpoof, string Effect, KindOfEyeshadow EyeshadowTexture,
       FormOfPackage PackageType) : base(productName, brand, priceCategoryOfProduct, Color, IsWaterpoof)
       {
            this.EyeshadowTexture = EyeshadowTexture;
            this.PackageType = PackageType;
        }
    }
}

