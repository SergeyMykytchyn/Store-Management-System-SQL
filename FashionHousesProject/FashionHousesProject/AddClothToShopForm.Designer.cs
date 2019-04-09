﻿namespace FashionHousesProject
{
    partial class AddClothToShopForm
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
            this.dataGridView_SH_CL = new System.Windows.Forms.DataGridView();
            this.label_CLSH_QTY = new System.Windows.Forms.Label();
            this.label_CLSH_COST = new System.Windows.Forms.Label();
            this.textBox_CLSH_QTY = new System.Windows.Forms.TextBox();
            this.textBox_CLSH_COST = new System.Windows.Forms.TextBox();
            this.btn_add_CL_to_SH = new System.Windows.Forms.Button();
            this.fashionHousesDataSet = new FashionHousesProject.FashionHousesDataSet();
            this.shopClothesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shopClothesTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.ShopClothesTableAdapter();
            this.fashionHousesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fashionHousesTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.FashionHousesTableAdapter();
            this.sHIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHADRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHQTYEMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHFHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.clothesInShopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothesInShopTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.ClothesInShopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SH_CL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesInShopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_SH_CL
            // 
            this.dataGridView_SH_CL.AutoGenerateColumns = false;
            this.dataGridView_SH_CL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SH_CL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sHIDDataGridViewTextBoxColumn,
            this.sHADRESSDataGridViewTextBoxColumn,
            this.sHQTYEMPDataGridViewTextBoxColumn,
            this.sHFHDataGridViewTextBoxColumn});
            this.dataGridView_SH_CL.DataSource = this.shopClothesBindingSource;
            this.dataGridView_SH_CL.Location = new System.Drawing.Point(13, 100);
            this.dataGridView_SH_CL.Name = "dataGridView_SH_CL";
            this.dataGridView_SH_CL.ReadOnly = true;
            this.dataGridView_SH_CL.RowTemplate.Height = 24;
            this.dataGridView_SH_CL.Size = new System.Drawing.Size(445, 150);
            this.dataGridView_SH_CL.TabIndex = 0;
            // 
            // label_CLSH_QTY
            // 
            this.label_CLSH_QTY.AutoSize = true;
            this.label_CLSH_QTY.Location = new System.Drawing.Point(527, 100);
            this.label_CLSH_QTY.Name = "label_CLSH_QTY";
            this.label_CLSH_QTY.Size = new System.Drawing.Size(106, 17);
            this.label_CLSH_QTY.TabIndex = 1;
            this.label_CLSH_QTY.Text = "Кiлькiсть одягу";
            // 
            // label_CLSH_COST
            // 
            this.label_CLSH_COST.AutoSize = true;
            this.label_CLSH_COST.Location = new System.Drawing.Point(530, 143);
            this.label_CLSH_COST.Name = "label_CLSH_COST";
            this.label_CLSH_COST.Size = new System.Drawing.Size(64, 17);
            this.label_CLSH_COST.TabIndex = 2;
            this.label_CLSH_COST.Text = "Вартiсть";
            // 
            // textBox_CLSH_QTY
            // 
            this.textBox_CLSH_QTY.Location = new System.Drawing.Point(654, 100);
            this.textBox_CLSH_QTY.Name = "textBox_CLSH_QTY";
            this.textBox_CLSH_QTY.Size = new System.Drawing.Size(123, 22);
            this.textBox_CLSH_QTY.TabIndex = 3;
            // 
            // textBox_CLSH_COST
            // 
            this.textBox_CLSH_COST.Location = new System.Drawing.Point(654, 143);
            this.textBox_CLSH_COST.Name = "textBox_CLSH_COST";
            this.textBox_CLSH_COST.Size = new System.Drawing.Size(123, 22);
            this.textBox_CLSH_COST.TabIndex = 4;
            // 
            // btn_add_CL_to_SH
            // 
            this.btn_add_CL_to_SH.Location = new System.Drawing.Point(543, 208);
            this.btn_add_CL_to_SH.Name = "btn_add_CL_to_SH";
            this.btn_add_CL_to_SH.Size = new System.Drawing.Size(140, 42);
            this.btn_add_CL_to_SH.TabIndex = 5;
            this.btn_add_CL_to_SH.Text = "Додати Одяг до магазину";
            this.btn_add_CL_to_SH.UseVisualStyleBackColor = true;
            this.btn_add_CL_to_SH.Click += new System.EventHandler(this.btn_add_CL_to_SH_Click);
            // 
            // fashionHousesDataSet
            // 
            this.fashionHousesDataSet.DataSetName = "FashionHousesDataSet";
            this.fashionHousesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shopClothesBindingSource
            // 
            this.shopClothesBindingSource.DataMember = "ShopClothes";
            this.shopClothesBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // shopClothesTableAdapter
            // 
            this.shopClothesTableAdapter.ClearBeforeFill = true;
            // 
            // fashionHousesBindingSource
            // 
            this.fashionHousesBindingSource.DataMember = "FashionHouses";
            this.fashionHousesBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // fashionHousesTableAdapter
            // 
            this.fashionHousesTableAdapter.ClearBeforeFill = true;
            // 
            // sHIDDataGridViewTextBoxColumn
            // 
            this.sHIDDataGridViewTextBoxColumn.DataPropertyName = "SH_ID";
            this.sHIDDataGridViewTextBoxColumn.HeaderText = "SH_ID";
            this.sHIDDataGridViewTextBoxColumn.Name = "sHIDDataGridViewTextBoxColumn";
            this.sHIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sHADRESSDataGridViewTextBoxColumn
            // 
            this.sHADRESSDataGridViewTextBoxColumn.DataPropertyName = "SH_ADRESS";
            this.sHADRESSDataGridViewTextBoxColumn.HeaderText = "Адреса Магазину";
            this.sHADRESSDataGridViewTextBoxColumn.Name = "sHADRESSDataGridViewTextBoxColumn";
            this.sHADRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHQTYEMPDataGridViewTextBoxColumn
            // 
            this.sHQTYEMPDataGridViewTextBoxColumn.DataPropertyName = "SH_QTY_EMP";
            this.sHQTYEMPDataGridViewTextBoxColumn.HeaderText = "Кiлькiсть працiвникiв";
            this.sHQTYEMPDataGridViewTextBoxColumn.Name = "sHQTYEMPDataGridViewTextBoxColumn";
            this.sHQTYEMPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sHFHDataGridViewTextBoxColumn
            // 
            this.sHFHDataGridViewTextBoxColumn.DataPropertyName = "SH_FH";
            this.sHFHDataGridViewTextBoxColumn.DataSource = this.fashionHousesBindingSource;
            this.sHFHDataGridViewTextBoxColumn.DisplayMember = "FH_NAME";
            this.sHFHDataGridViewTextBoxColumn.HeaderText = "Дом Моди";
            this.sHFHDataGridViewTextBoxColumn.Name = "sHFHDataGridViewTextBoxColumn";
            this.sHFHDataGridViewTextBoxColumn.ReadOnly = true;
            this.sHFHDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sHFHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sHFHDataGridViewTextBoxColumn.ValueMember = "FH_ID";
            // 
            // clothesInShopBindingSource
            // 
            this.clothesInShopBindingSource.DataMember = "ClothesInShop";
            this.clothesInShopBindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // clothesInShopTableAdapter
            // 
            this.clothesInShopTableAdapter.ClearBeforeFill = true;
            // 
            // AddClothToShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 313);
            this.Controls.Add(this.btn_add_CL_to_SH);
            this.Controls.Add(this.textBox_CLSH_COST);
            this.Controls.Add(this.textBox_CLSH_QTY);
            this.Controls.Add(this.label_CLSH_COST);
            this.Controls.Add(this.label_CLSH_QTY);
            this.Controls.Add(this.dataGridView_SH_CL);
            this.MaximumSize = new System.Drawing.Size(830, 360);
            this.MinimumSize = new System.Drawing.Size(830, 360);
            this.Name = "AddClothToShopForm";
            this.Text = "Додати Одяг до магазину";
            this.Load += new System.EventHandler(this.AddClothToShopForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SH_CL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shopClothesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesInShopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_SH_CL;
        private System.Windows.Forms.Label label_CLSH_QTY;
        private System.Windows.Forms.Label label_CLSH_COST;
        private System.Windows.Forms.TextBox textBox_CLSH_QTY;
        private System.Windows.Forms.TextBox textBox_CLSH_COST;
        private System.Windows.Forms.Button btn_add_CL_to_SH;
        private FashionHousesDataSet fashionHousesDataSet;
        private System.Windows.Forms.BindingSource shopClothesBindingSource;
        private FashionHousesDataSetTableAdapters.ShopClothesTableAdapter shopClothesTableAdapter;
        private System.Windows.Forms.BindingSource fashionHousesBindingSource;
        private FashionHousesDataSetTableAdapters.FashionHousesTableAdapter fashionHousesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHADRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHQTYEMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn sHFHDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clothesInShopBindingSource;
        private FashionHousesDataSetTableAdapters.ClothesInShopTableAdapter clothesInShopTableAdapter;
    }
}