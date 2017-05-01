using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using lab_3.Classes;

namespace lab_3.Factories
{
    //TO DO:
    //enums
    //controls array to list
    public abstract class CosmeticFactory
    {
        const int backspaceCode = 8;

        const int nameIndex = 0;
        const int brandIndex = 1;
        const int priceCategoryIndex = 2;
        const int colorButtonIndex = 3;

        public abstract object GetClassName();


        public void TextBoxString_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != backspaceCode) && (e.KeyChar != ' ') && !Char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void TextBoxDigits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != backspaceCode))
            {
                e.Handled = true;
            }
        }


        public TextBox GetTextBox(string name, Size size, Point location, int tabIndex,
            KeyPressEventHandler keyPressEvent)
        {
            TextBox textboxToCreate = new TextBox();
            textboxToCreate.Location = location;
            textboxToCreate.Name = name;
            textboxToCreate.TabIndex = tabIndex;
            textboxToCreate.KeyPress += keyPressEvent;
            return textboxToCreate;
        }

        public Label GetLabel(string name, string text, Size size, Point location, int tabIndex)
        {
            Label labelToCreate = new Label();
            labelToCreate.Location = location;
            labelToCreate.Name = name;
            labelToCreate.Text = text;
            labelToCreate.Size = size;
            labelToCreate.BackColor = Color.Transparent;
            labelToCreate.TabIndex = tabIndex;
            return labelToCreate;
        }

        public ComboBox GetComboBox(string name, Size size, Point location, int tabIndex, Type enumType)
        {
            ComboBox comboBoxToCreate = new ComboBox();
            comboBoxToCreate.Name = name;
            comboBoxToCreate.Size = size;
            comboBoxToCreate.TabIndex = tabIndex;
            comboBoxToCreate.Items.AddRange(Enum.GetNames(enumType));
            comboBoxToCreate.SelectedIndex = 0;
            comboBoxToCreate.Location = location;
            comboBoxToCreate.DropDownStyle = ComboBoxStyle.DropDownList;
            return comboBoxToCreate;
        }
         //??????????????????
        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Button buttonToChange = (Button)sender;
                buttonToChange.BackColor = colorDialog.Color;
            }
        }

        public Button GetPaletteButton(string name, Size size, Point location, int tabIndex, EventHandler buttonClick)
        {
            Button buttonToCreate = new Button();
            buttonToCreate.Name = name;
            buttonToCreate.Size = size;
            buttonToCreate.Location = location;
            buttonToCreate.TabIndex = tabIndex;
            buttonToCreate.Click += buttonClick;
            return buttonToCreate;
        }

        public virtual List<Control> GetListControl(Size size, int leftCoord)
        {
            List<Control> resultList = new List<Control>();

            resultList.Add(GetLabel("productName", "Название продукта", size, new Point(leftCoord, 10), 1));
            resultList.Add(GetTextBox("productName", size, new Point(leftCoord, 30), 2, TextBoxString_KeyPress));
     

            resultList.Add(GetLabel("brand", "Бренд", size, new Point(leftCoord, 55), 3));
            resultList.Add(GetTextBox("brand", size, new Point(leftCoord, 70), 4, TextBoxString_KeyPress));
     

            resultList.Add(GetLabel("priceCategory", "Ценовая категория", size, new Point(leftCoord, 95), 5));
            resultList.Add(GetComboBox("priceCategory", size, new Point(leftCoord, 110), 6, CosmeticProduct.PriceCategory.lux.GetType()));
      

            resultList.Add(GetLabel("color", "Цвет", size, new Point(leftCoord, 135), 7));
            resultList.Add(GetPaletteButton("colorButton", new Size(50, 30), new Point(leftCoord, 150), 8, buttonColor_Click));

            return resultList;
        }


        public abstract CosmeticProduct GetSomeCosmeticProduct(int index);

        public Control[] GetComponentsForInput(Control.ControlCollection controlList)
        {
            List<Control> result = new List<Control>();
            foreach (Control someControl in controlList)
            {
                if (!(someControl is Label))
                {
                    result.Add(someControl);
                }
            }
            return result.ToArray();
        }

        public virtual void GetDataFromComponents(CosmeticProduct currentProduct, Control.ControlCollection controls)
        {
            Control[] controlList = GetComponentsForInput(controls);
            try
            {
                currentProduct.ProductName = controlList[nameIndex].Text;
                currentProduct.Brand = controlList[brandIndex].Text;
                currentProduct.PriceCategoryOfProduct = (CosmeticProduct.PriceCategory)Enum.Parse(typeof(CosmeticProduct.PriceCategory), controlList[priceCategoryIndex].Text);
                currentProduct.Color = controlList[colorButtonIndex].BackColor;
            }
            catch
            {
                MessageBox.Show("Проверьте данные на корректность!");
                throw new Exception();
            }
        }

        public virtual void LoadDataToComponets(CosmeticProduct currentProduct, Control.ControlCollection controls)
        {
            Control[] controlList = GetComponentsForInput(controls);
            controlList[nameIndex].Text = Convert.ToString(currentProduct.ProductName);
            controlList[brandIndex].Text = Convert.ToString(currentProduct.Brand);
            controlList[priceCategoryIndex].Text = Enum.GetName(typeof(CosmeticProduct.PriceCategory), currentProduct.PriceCategoryOfProduct);

        }


    }
}
