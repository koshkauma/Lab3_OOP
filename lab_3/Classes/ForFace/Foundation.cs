﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace lab_3.Classes.ForFace
{
    public class Foundation: FaceProduct
    {
        public enum GradeOfCoverage
        {
            [Description("Плотное")]
            full,
            [Description("Ежедневное")]
            soft,
            [Description("Для съемок")]
            hdEffect
        }
        public GradeOfCoverage Coverage { get; set; }
        public bool isSPF { get; set; } //может типа сделать еще чек бокс и если есть спф указать его значение

        public Foundation(string ProductName, string Brand, PriceCategory PriceCategoryOfProduct, Color Color, SkinType TypeOfSkin, TypeOfFinish Finish, GradeOfCoverage Coverage, bool isSPF): 
            base(ProductName, Brand, PriceCategoryOfProduct, Color, TypeOfSkin, Finish)
        {
            this.isSPF = isSPF;
            this.Coverage = Coverage;
        }

        public Foundation(int classIndex): base(classIndex)
        { }


    }
}
