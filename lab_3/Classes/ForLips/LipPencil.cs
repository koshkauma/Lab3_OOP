using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes
{
    public class LipPencil: LipProduct
    {
        public enum TypeOfPencil
        {
            [Description("Автоматический")]
            auto,
            [Description("Деревянный")]
            wood
        }
        public TypeOfPencil PencilDevice { get; set; }
        public enum TypeOfTexture
        {
            [Description("Мягкая")]
            soft,
            [Description("Твердая")]
            hard
        }
        public TypeOfTexture PencilTexture { get; set; }

        public LipPencil(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, string Aromatizer,
        TypeOfPencil PencilDevice, TypeOfTexture PencilTexture) : base(ProductName, Brand, PriceCategoryOfProduct, Color, Aromatizer)
        {
            this.PencilDevice = PencilDevice;
            this.PencilTexture = PencilTexture;
        }

        public LipPencil(int classIndex): base(classIndex)
        { }
    }
}
