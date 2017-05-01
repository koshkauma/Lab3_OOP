using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes
{
    public class LipPencil: LipProduct
    {
        public enum TypeOfPencil { auto, wood}
        public TypeOfPencil PencilDevice { get; set; }
        public enum TypeOfTexture { soft, hard }
        public TypeOfTexture PencilTexture { get; set; }

        public LipPencil(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, string Aromatizer,
        TypeOfPencil PencilDevice, TypeOfTexture PencilTexture) : base(ProductName, Brand, PriceCategoryOfProduct, Color, Aromatizer)
        {
            this.PencilDevice = PencilDevice;
            this.PencilTexture = PencilTexture;
        }

    }
}
