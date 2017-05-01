using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForEyes
{
    public class Mascara: EyesProduct
    {
       public string Effect { get; set; }
       public enum MaterialOfBrush { silicone, plastic}
       public MaterialOfBrush BrushMaterial { get; set; }
       public enum FormOfBrush { straigh, oval, coneShaped, curved, ballShaped }
       public FormOfBrush BrushForm { get; set; }


       public Mascara(string productName, string brand, PriceCategory priceCategoryOfProduct, Color Color, bool IsWaterpoof, string Effect, MaterialOfBrush BrushMaterial,
           FormOfBrush BrushForm) : base(productName, brand, priceCategoryOfProduct, Color, IsWaterpoof)
       {
            this.IsWaterproof = IsWaterproof;
            this.BrushForm = BrushForm;
            this.BrushMaterial = BrushMaterial;
       }

    }
}
