using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;
namespace lab_3.Classes.ForNails
{
    public class NailPolish: CosmeticProduct
    {
        public int Durability { get; set; } //стойкость 
        public enum TypesOfEffects
        {
            [Description("Песок")]
            sandTexture,
            [Description("Глиттер")]
            glitter,
            [Description("Термо-лак")]
            termo,
            [Description("Кракелюр(трещины)")]
            crack,
            [Description("Матовое покрытие")]
            matt,
            [Description("Неон")]
            neon,
            [Description("Лак-магнит")]
            magnetic,
            [Description("Голографический")]
            holographic
        }
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
