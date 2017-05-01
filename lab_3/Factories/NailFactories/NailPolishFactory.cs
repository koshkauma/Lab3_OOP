using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using lab_3.Classes;
using lab_3.Classes.ForNails;
using System;


namespace lab_3.Factories.NailFactories
{
    public class NailPolishFactory: CosmeticFactory
    {
        const int durabilityIndex = 4;
        const int effectIndex = 5;

        public override object GetClassName()
        {
            Object obj = new Object();
            obj = "Лак для ногтей";
            return obj;
       }

        public override List<Control> GetListControl(Size size, int leftCoord)
        {
            List<Control> resultList = base.GetListControl(size, leftCoord);
         
            resultList.Add(GetLabel("durability", "Заявленное кол-во дней носки", size, new Point(leftCoord, 185), 9));
            resultList.Add(GetTextBox("durability", size, new Point(leftCoord, 205), 10, TextBoxDigits_KeyPress));
     
            resultList.Add(GetLabel("effect", "Специальный эффект лака", size, new Point(leftCoord, 230), 11));
            resultList.Add(GetComboBox("effect", size, new Point(leftCoord, 250), 12, NailPolish.TypesOfEffects.crack.GetType()));

            return resultList;
        }


        public override void GetDataFromComponents(CosmeticProduct currentProduct, Control.ControlCollection controls)
        {
            base.GetDataFromComponents(currentProduct, controls);

            Control[] controlList = GetComponentsForInput(controls);
            NailPolish currentNailPolish = (NailPolish)currentProduct;
            controlList[durabilityIndex].Text = Convert.ToString(currentNailPolish.Durability);
            controlList[effectIndex].Text = Convert.ToString(currentNailPolish.SpecialEffect);
        }

        public override CosmeticProduct GetSomeCosmeticProduct(int index)
        {
            return new NailPolish(index);
        }


    }
}
