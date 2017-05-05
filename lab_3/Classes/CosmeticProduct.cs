using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes
{
    public class CosmeticProduct
    {
        public string ProductName { get; set; }
        public string Brand { get; set; }
        public enum PriceCategory
        {
           [Description("Масс-маркет")]
           massMarket,
           [Description("Люкс")]
           lux,
           [Description("Профессиональная")]
           professional
        };
        public PriceCategory PriceCategoryOfProduct { get; set; }
        public Color Color { get; set; }

        private int classIndex;
        public int ClassIndex
        {
            get
            {
                return classIndex;
            }
        }

        public CosmeticProduct(int classIndex)
        {
            this.classIndex = classIndex;
        }

        public CosmeticProduct(string productName, string brand, PriceCategory priceCategoryOfProduct, Color Color)
        {
            this.ProductName = productName;
            this.Brand = brand;
            this.PriceCategoryOfProduct = priceCategoryOfProduct;
            this.Color = Color;
        }

    }
    
}
