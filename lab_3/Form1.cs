using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lab_3.Factories;
using lab_3.Classes;

namespace lab_3
{
    public partial class serializeForm : Form
    {
        CosmeticListClass list = new CosmeticListClass();
       
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
            panelAdd.Tag = factoryFormEditor.FactoryList[comboBoxItems.SelectedIndex].GetSomeCosmeticProduct(comboBoxItems.SelectedIndex);
            listBoxOfProducts.DataSource = list.CosmeticList;
            listBoxOfProducts.DisplayMember = "ProductName";   
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
            panelAdd.Controls.Clear();
            panelAdd.Controls.AddRange(factoryFormEditor.FactoryList[comboBoxItems.SelectedIndex].GetListControl(new Size(200, 20), 10).ToArray());
            panelAdd.Tag = factoryFormEditor.FactoryList[comboBoxItems.SelectedIndex].GetSomeCosmeticProduct(comboBoxItems.SelectedIndex);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CosmeticProduct temp = (CosmeticProduct)panelAdd.Tag;
            try
            {
                factoryFormEditor.FactoryList[temp.ClassIndex].GetDataFromComponents(temp, panelAdd.Controls);
            }
            catch
            {
                MessageBox.Show("Данные некорректны! Пожалуйста, повторите ввод");
            }
            panelAdd.Tag = panelAdd.Tag = factoryFormEditor.FactoryList[comboBoxItems.SelectedIndex].GetSomeCosmeticProduct(comboBoxItems.SelectedIndex);
            list.CosmeticList.Add(temp);
        }

        private void listBoxOfProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CosmeticProduct currentProduct = (CosmeticProduct)listBoxOfProducts.SelectedItem;
            if (currentProduct != null)
            {
                panelEdit.Controls.Clear();
                panelEdit.Controls.AddRange(factoryFormEditor.FactoryList[currentProduct.ClassIndex].GetListControl(new Size(200, 20), 10).ToArray());
                factoryFormEditor.FactoryList[currentProduct.ClassIndex].LoadDataToComponets(currentProduct, panelEdit.Controls);
                labelEdit.Text = comboBoxItems.Items[currentProduct.ClassIndex].ToString();
                panelEdit.Tag = currentProduct;
            }


        }
    }
}
