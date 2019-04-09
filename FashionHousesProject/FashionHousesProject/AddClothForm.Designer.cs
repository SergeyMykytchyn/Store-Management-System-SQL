﻿namespace FashionHousesProject
{
    partial class AddClothForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_DES = new System.Windows.Forms.Label();
            this.label_СOLOR = new System.Windows.Forms.Label();
            this.comboBox_COLOR = new System.Windows.Forms.ComboBox();
            this.clothesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fashionHousesDataSet = new FashionHousesProject.FashionHousesDataSet();
            this.label_CAT = new System.Windows.Forms.Label();
            this.comboBox_CAT = new System.Windows.Forms.ComboBox();
            this.clothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_DES = new System.Windows.Forms.TextBox();
            this.dataGridViewDES = new System.Windows.Forms.DataGridView();
            this.dESIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESPASSPORTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESGENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dESFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dESBIRTHDAYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.designersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label_ENTER_DES_NAME = new System.Windows.Forms.Label();
            this.comboBox_ENTER_DES_NAME = new System.Windows.Forms.ComboBox();
            this.designersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button_Filter_By_NAME = new System.Windows.Forms.Button();
            this.button_ADD_CL = new System.Windows.Forms.Button();
            this.designersTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.DesignersTableAdapter();
            this.fashionHousesTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.FashionHousesTableAdapter();
            this.clothesTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.ClothesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDES)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_DES
            // 
            this.label_DES.AutoSize = true;
            this.label_DES.Location = new System.Drawing.Point(781, 137);
            this.label_DES.Name = "label_DES";
            this.label_DES.Size = new System.Drawing.Size(42, 17);
            this.label_DES.TabIndex = 2;
            this.label_DES.Text = "Опис";
            // 
            // label_СOLOR
            // 
            this.label_СOLOR.AutoSize = true;
            this.label_СOLOR.Location = new System.Drawing.Point(781, 244);
            this.label_СOLOR.Name = "label_СOLOR";
            this.label_СOLOR.Size = new System.Drawing.Size(44, 17);
            this.label_СOLOR.TabIndex = 3;
            this.label_СOLOR.Text = "Колiр";
            // 
            // comboBox_COLOR
            // 
            this.comboBox_COLOR.DataSource = this.clothesBindingSource1;
            this.comboBox_COLOR.DisplayMember = "CL_COLOR";
            this.comboBox_COLOR.FormattingEnabled = true;
            this.comboBox_COLOR.Location = new System.Drawing.Point(915, 234);
            this.comboBox_COLOR.Name = "comboBox_COLOR";
            this.comboBox_COLOR.Size = new System.Drawing.Size(121, 24);
            this.comboBox_COLOR.TabIndex = 5;
            this.comboBox_COLOR.ValueMember = "CL_ID";
            // 
            // clothesBindingSource1
            // 
            this.clothesBindingSource1.DataMember = "Clothes";
            this.clothesBindingSource1.DataSource = this.fashionHousesDataSet;
            // 
            // fashionHousesDataSet
            // 
            this.fashionHousesDataSet.DataSetName = "FashionHousesDataSet";
            this.fashionHousesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_CAT
            // 
            this.label_CAT.AutoSize = true;
            this.label_CAT.Location = new System.Drawing.Point(781, 186);
            this.label_CAT.Name = "label_CAT";
            this.label_CAT.Size = new System.Drawing.Size(72, 17);
            this.label_CAT.TabIndex = 6;
            this.label_CAT.Text = "Категорiя";
            // 
            // comboBox_CAT
            // 
            this.comboBox_CAT.DataSource = this.clothesBindingSource;
            this.comboBox_CAT.DisplayMember = "CL_CATEGORY";
            this.comboBox_CAT.FormattingEnabled = true;
            this.comboBox_CAT.Location = new System.Drawing.Point(915, 179);
            this.comboBox_CAT.Name = "comboBox_CAT";
            this.comboBox_CAT.Size = new System.Drawing.Size(121, 24);
            this.comboBox_CAT.TabIndex = 7;
            this.comboBox_CAT.ValueMember = "CL_ID";
            // 
            // clothesBindingSource
            // 
            this.clothesBindingSource.DataMember = "Clothes";
            this.clothesBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // textBox_DES
            // 
            this.textBox_DES.Location = new System.Drawing.Point(915, 132);
            this.textBox_DES.Name = "textBox_DES";
            this.textBox_DES.Size = new System.Drawing.Size(121, 22);
            this.textBox_DES.TabIndex = 9;
            // 
            // dataGridViewDES
            // 
            this.dataGridViewDES.AutoGenerateColumns = false;
            this.dataGridViewDES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDES.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dESIDDataGridViewTextBoxColumn,
            this.dESFULLNAMEDataGridViewTextBoxColumn,
            this.dESPASSPORTDataGridViewTextBoxColumn,
            this.dESGENDERDataGridViewTextBoxColumn,
            this.dESFHDataGridViewTextBoxColumn,
            this.dESBIRTHDAYDataGridViewTextBoxColumn});
            this.dataGridViewDES.DataSource = this.designersBindingSource;
            this.dataGridViewDES.Location = new System.Drawing.Point(15, 77);
            this.dataGridViewDES.Name = "dataGridViewDES";
            this.dataGridViewDES.ReadOnly = true;
            this.dataGridViewDES.RowTemplate.Height = 24;
            this.dataGridViewDES.Size = new System.Drawing.Size(750, 262);
            this.dataGridViewDES.TabIndex = 10;
            // 
            // dESIDDataGridViewTextBoxColumn
            // 
            this.dESIDDataGridViewTextBoxColumn.DataPropertyName = "DES_ID";
            this.dESIDDataGridViewTextBoxColumn.HeaderText = "DES_ID";
            this.dESIDDataGridViewTextBoxColumn.Name = "dESIDDataGridViewTextBoxColumn";
            this.dESIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dESFULLNAMEDataGridViewTextBoxColumn
            // 
            this.dESFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "DES_FULLNAME";
            this.dESFULLNAMEDataGridViewTextBoxColumn.HeaderText = "Iм\'я Дизанера";
            this.dESFULLNAMEDataGridViewTextBoxColumn.Name = "dESFULLNAMEDataGridViewTextBoxColumn";
            this.dESFULLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESPASSPORTDataGridViewTextBoxColumn
            // 
            this.dESPASSPORTDataGridViewTextBoxColumn.DataPropertyName = "DES_PASSPORT";
            this.dESPASSPORTDataGridViewTextBoxColumn.HeaderText = "Паспорт Дизайнера";
            this.dESPASSPORTDataGridViewTextBoxColumn.Name = "dESPASSPORTDataGridViewTextBoxColumn";
            this.dESPASSPORTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESGENDERDataGridViewTextBoxColumn
            // 
            this.dESGENDERDataGridViewTextBoxColumn.DataPropertyName = "DES_GENDER";
            this.dESGENDERDataGridViewTextBoxColumn.HeaderText = "Пол Дизайнера";
            this.dESGENDERDataGridViewTextBoxColumn.Name = "dESGENDERDataGridViewTextBoxColumn";
            this.dESGENDERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dESFHDataGridViewTextBoxColumn
            // 
            this.dESFHDataGridViewTextBoxColumn.DataPropertyName = "DES_FH";
            this.dESFHDataGridViewTextBoxColumn.DataSource = this.fashionHousesBindingSource;
            this.dESFHDataGridViewTextBoxColumn.DisplayMember = "FH_NAME";
            this.dESFHDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.dESFHDataGridViewTextBoxColumn.Name = "dESFHDataGridViewTextBoxColumn";
            this.dESFHDataGridViewTextBoxColumn.ReadOnly = true;
            this.dESFHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dESFHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dESFHDataGridViewTextBoxColumn.ValueMember = "FH_ID";
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataMember = "FashionHouses";
            this.fashionHousesBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // dESBIRTHDAYDataGridViewTextBoxColumn
            // 
            this.dESBIRTHDAYDataGridViewTextBoxColumn.DataPropertyName = "DES_BIRTHDAY";
            this.dESBIRTHDAYDataGridViewTextBoxColumn.HeaderText = "День Народження";
            this.dESBIRTHDAYDataGridViewTextBoxColumn.Name = "dESBIRTHDAYDataGridViewTextBoxColumn";
            this.dESBIRTHDAYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // designersBindingSource
            // 
            this.designersBindingSource.DataMember = "Designers";
            this.designersBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // label_ENTER_DES_NAME
            // 
            this.label_ENTER_DES_NAME.AutoSize = true;
            this.label_ENTER_DES_NAME.Location = new System.Drawing.Point(12, 42);
            this.label_ENTER_DES_NAME.Name = "label_ENTER_DES_NAME";
            this.label_ENTER_DES_NAME.Size = new System.Drawing.Size(159, 17);
            this.label_ENTER_DES_NAME.TabIndex = 11;
            this.label_ENTER_DES_NAME.Text = "Введiть iм\'я дизайнера";
            // 
            // comboBox_ENTER_DES_NAME
            // 
            this.comboBox_ENTER_DES_NAME.DataSource = this.designersBindingSource1;
            this.comboBox_ENTER_DES_NAME.DisplayMember = "DES_FULLNAME";
            this.comboBox_ENTER_DES_NAME.FormattingEnabled = true;
            this.comboBox_ENTER_DES_NAME.Location = new System.Drawing.Point(214, 38);
            this.comboBox_ENTER_DES_NAME.Name = "comboBox_ENTER_DES_NAME";
            this.comboBox_ENTER_DES_NAME.Size = new System.Drawing.Size(180, 24);
            this.comboBox_ENTER_DES_NAME.TabIndex = 12;
            this.comboBox_ENTER_DES_NAME.ValueMember = "DES_ID";
            // 
            // designersBindingSource1
            // 
            this.designersBindingSource1.DataMember = "Designers";
            this.designersBindingSource1.DataSource = this.fashionHousesDataSet;
            // 
            // button_Filter_By_NAME
            // 
            this.button_Filter_By_NAME.Location = new System.Drawing.Point(433, 33);
            this.button_Filter_By_NAME.Name = "button_Filter_By_NAME";
            this.button_Filter_By_NAME.Size = new System.Drawing.Size(180, 29);
            this.button_Filter_By_NAME.TabIndex = 13;
            this.button_Filter_By_NAME.Text = "Вiдфiльтрувати за iм\'ям";
            this.button_Filter_By_NAME.UseVisualStyleBackColor = true;
            this.button_Filter_By_NAME.Click += new System.EventHandler(this.button_Filter_By_NAME_Click);
            // 
            // button_ADD_CL
            // 
            this.button_ADD_CL.Location = new System.Drawing.Point(871, 297);
            this.button_ADD_CL.Name = "button_ADD_CL";
            this.button_ADD_CL.Size = new System.Drawing.Size(110, 42);
            this.button_ADD_CL.TabIndex = 14;
            this.button_ADD_CL.Text = "Додати Одяг";
            this.button_ADD_CL.UseVisualStyleBackColor = true;
            this.button_ADD_CL.Click += new System.EventHandler(this.button_ADD_CL_Click);
            // 
            // designersTableAdapter
            // 
            this.designersTableAdapter.ClearBeforeFill = true;
            // 
            // fashionHousesTableAdapter
            // 
            this.fashionHousesTableAdapter.ClearBeforeFill = true;
            // 
            // clothesTableAdapter
            // 
            this.clothesTableAdapter.ClearBeforeFill = true;
            // 
            // AddClothForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 373);
            this.Controls.Add(this.button_ADD_CL);
            this.Controls.Add(this.button_Filter_By_NAME);
            this.Controls.Add(this.comboBox_ENTER_DES_NAME);
            this.Controls.Add(this.label_ENTER_DES_NAME);
            this.Controls.Add(this.dataGridViewDES);
            this.Controls.Add(this.textBox_DES);
            this.Controls.Add(this.comboBox_CAT);
            this.Controls.Add(this.label_CAT);
            this.Controls.Add(this.comboBox_COLOR);
            this.Controls.Add(this.label_СOLOR);
            this.Controls.Add(this.label_DES);
            this.MaximumSize = new System.Drawing.Size(1100, 420);
            this.MinimumSize = new System.Drawing.Size(1100, 420);
            this.Name = "AddClothForm";
            this.Text = "Додати Одяг";
            this.Load += new System.EventHandler(this.AddClothForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDES)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.designersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_DES;
        private System.Windows.Forms.Label label_СOLOR;
        private System.Windows.Forms.ComboBox comboBox_COLOR;
        private System.Windows.Forms.Label label_CAT;
        private System.Windows.Forms.ComboBox comboBox_CAT;
        private System.Windows.Forms.TextBox textBox_DES;
        private System.Windows.Forms.DataGridView dataGridViewDES;
        private System.Windows.Forms.Label label_ENTER_DES_NAME;
        private System.Windows.Forms.ComboBox comboBox_ENTER_DES_NAME;
        private System.Windows.Forms.Button button_Filter_By_NAME;
        private System.Windows.Forms.Button button_ADD_CL;
        private FashionHousesDataSet fashionHousesDataSet;
        private System.Windows.Forms.BindingSource designersBindingSource;
        private FashionHousesDataSetTableAdapters.DesignersTableAdapter designersTableAdapter;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private FashionHousesDataSetTableAdapters.FashionHousesTableAdapter fashionHousesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESPASSPORTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESGENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dESFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dESBIRTHDAYDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clothesBindingSource;
        private FashionHousesDataSetTableAdapters.ClothesTableAdapter clothesTableAdapter;
        private System.Windows.Forms.BindingSource clothesBindingSource1;
        private System.Windows.Forms.BindingSource designersBindingSource1;
    }
}