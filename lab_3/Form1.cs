using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lab_3.Factories;

namespace lab_3
{
    public partial class serializeForm : Form
    {

       
        public serializeForm()
        {
            InitializeComponent();
            foreach (CosmeticFactory factory in factoryFormEditor.FactoryList)
            {
               comboBoxItems.Items.Add(factory.GetClassName());
            }
            comboBoxItems.SelectedIndex = 0;
            panelAdd.Controls.Clear();
            panelAdd.Controls.AddRange(factoryFormEditor.FactoryList[comboBoxItems.SelectedIndex].GetListControl(new Size(200, 15), 10).ToArray());
        }

        private static AllProductsFactory factoryFormEditor = new AllProductsFactory();

        private void serializeForm_Load(object sender, EventArgs e)
        {

        }

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
