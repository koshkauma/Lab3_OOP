﻿namespace lab_3
{
    partial class serializeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonDelete = new System.Windows.Forms.Button();
            this.panelAdd = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.comboBoxItems = new System.Windows.Forms.ComboBox();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.listBoxOfProducts = new System.Windows.Forms.ListBox();
            this.labelEdit = new System.Windows.Forms.Label();
            this.menuStripFile = new System.Windows.Forms.MenuStrip();
            this.работаСФайломToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сериализоватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.десToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonClearList = new System.Windows.Forms.Button();
            this.menuStripFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(641, 556);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // panelAdd
            // 
            this.panelAdd.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelAdd.Location = new System.Drawing.Point(29, 61);
            this.panelAdd.Name = "panelAdd";
            this.panelAdd.Size = new System.Drawing.Size(262, 489);
            this.panelAdd.TabIndex = 3;
            this.panelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAdd_Paint);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(126, 556);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(410, 556);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(92, 23);
            this.buttonEdit.TabIndex = 5;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // comboBoxItems
            // 
            this.comboBoxItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItems.FormattingEnabled = true;
            this.comboBoxItems.Location = new System.Drawing.Point(29, 34);
            this.comboBoxItems.Name = "comboBoxItems";
            this.comboBoxItems.Size = new System.Drawing.Size(262, 21);
            this.comboBoxItems.TabIndex = 6;
            this.comboBoxItems.SelectedIndexChanged += new System.EventHandler(this.comboBoxItems_SelectedIndexChanged);
            // 
            // panelEdit
            // 
            this.panelEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelEdit.Location = new System.Drawing.Point(328, 61);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(256, 489);
            this.panelEdit.TabIndex = 7;
            // 
            // listBoxOfProducts
            // 
            this.listBoxOfProducts.FormattingEnabled = true;
            this.listBoxOfProducts.Location = new System.Drawing.Point(641, 61);
            this.listBoxOfProducts.Name = "listBoxOfProducts";
            this.listBoxOfProducts.Size = new System.Drawing.Size(168, 485);
            this.listBoxOfProducts.TabIndex = 8;
            this.listBoxOfProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxOfProducts_SelectedIndexChanged);
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Location = new System.Drawing.Point(407, 34);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(0, 13);
            this.labelEdit.TabIndex = 9;
            // 
            // menuStripFile
            // 
            this.menuStripFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСФайломToolStripMenuItem,
            this.выходToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStripFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripFile.Name = "menuStripFile";
            this.menuStripFile.Size = new System.Drawing.Size(840, 24);
            this.menuStripFile.TabIndex = 10;
            this.menuStripFile.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // работаСФайломToolStripMenuItem
            // 
            this.работаСФайломToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сериализоватьToolStripMenuItem,
            this.десToolStripMenuItem});
            this.работаСФайломToolStripMenuItem.Name = "работаСФайломToolStripMenuItem";
            this.работаСФайломToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.работаСФайломToolStripMenuItem.Text = "Работа с файлом";
            // 
            // сериализоватьToolStripMenuItem
            // 
            this.сериализоватьToolStripMenuItem.Name = "сериализоватьToolStripMenuItem";
            this.сериализоватьToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.сериализоватьToolStripMenuItem.Text = "Сериализовать";
            this.сериализоватьToolStripMenuItem.Click += new System.EventHandler(this.сериализоватьToolStripMenuItem_Click);
            // 
            // десToolStripMenuItem
            // 
            this.десToolStripMenuItem.Name = "десToolStripMenuItem";
            this.десToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.десToolStripMenuItem.Text = "Десериализовать";
            this.десToolStripMenuItem.Click += new System.EventHandler(this.десToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Text files(*.txt)|*.txt";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // buttonClearList
            // 
            this.buttonClearList.Location = new System.Drawing.Point(734, 556);
            this.buttonClearList.Name = "buttonClearList";
            this.buttonClearList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonClearList.Size = new System.Drawing.Size(75, 23);
            this.buttonClearList.TabIndex = 11;
            this.buttonClearList.Text = "Очистить";
            this.buttonClearList.UseVisualStyleBackColor = true;
            this.buttonClearList.Click += new System.EventHandler(this.buttonClearList_Click);
            // 
            // serializeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 605);
            this.Controls.Add(this.buttonClearList);
            this.Controls.Add(this.labelEdit);
            this.Controls.Add(this.listBoxOfProducts);
            this.Controls.Add(this.panelEdit);
            this.Controls.Add(this.comboBoxItems);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.panelAdd);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.menuStripFile);
            this.MainMenuStrip = this.menuStripFile;
            this.Name = "serializeForm";
            this.Text = "Лаб. работа №3";
            this.Load += new System.EventHandler(this.serializeForm_Load);
            this.menuStripFile.ResumeLayout(false);
            this.menuStripFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelAdd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.ComboBox comboBoxItems;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.ListBox listBoxOfProducts;
        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.MenuStrip menuStripFile;
        private System.Windows.Forms.ToolStripMenuItem работаСФайломToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сериализоватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem десToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonClearList;
    }
}

