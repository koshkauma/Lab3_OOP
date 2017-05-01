using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
namespace lab_3.Classes.ForNails
{
    public class NailPolish: CosmeticProduct
    {
        public int Durability { get; set; } //стойкость 
        public enum TypesOfEffects { sandTexture, glitter, termo, crack, matt, neon, magnetic, holographic }
        public TypesOfEffects SpecialEffect { get; set; }
        
        public NailPolish(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, int Durability, TypesOfEffects SpecialEffect):
            base(ProductName, Brand, PriceCategoryOfProduct, Color)
        {
            this.Durability = Durability;
            this.SpecialEffect = SpecialEffect;
        }

        public NailPolish(int classIndex): base(classIndex)
        { }

    }
}
