﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace lab_3.Classes.ForLips
{
    public class LipGloss: LipProduct
    {
       public bool isShimmer { get; set; } //содержит ли блестки
       public enum GradeOfCoverage { fullCoverage, semitransparent }; 
       public GradeOfCoverage Coverage { get; set; }

        public LipGloss(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, string Aromatizer,
        GradeOfCoverage Coverage, bool isShimmer) : base(ProductName, Brand, PriceCategoryOfProduct, Color, Aromatizer)
        {
            this.isShimmer = isShimmer;
            this.Coverage = Coverage;
        }
    }
}