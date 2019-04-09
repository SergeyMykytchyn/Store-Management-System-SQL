namespace FashionHousesProject
{
    partial class ShowMeClothInShops
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
            this.dataGridView_CLSH = new System.Windows.Forms.DataGridView();
            this.btn_DEL_CL_FROM_SH = new System.Windows.Forms.Button();
            this.btn_CHANGE_CLSH = new System.Windows.Forms.Button();
            this.fashionHousesDataSet = new FashionHousesProject.FashionHousesDataSet();
            this.clothesInShopbindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clothesInShopTableAdapter = new FashionHousesProject.FashionHousesDataSetTableAdapters.ClothesInShopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CLSH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesInShopbindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_CLSH
            // 
            this.dataGridView_CLSH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CLSH.Location = new System.Drawing.Point(12, 61);
            this.dataGridView_CLSH.Name = "dataGridView_CLSH";
            this.dataGridView_CLSH.ReadOnly = true;
            this.dataGridView_CLSH.RowTemplate.Height = 24;
            this.dataGridView_CLSH.Size = new System.Drawing.Size(747, 286);
            this.dataGridView_CLSH.TabIndex = 0;
            // 
            // btn_DEL_CL_FROM_SH
            // 
            this.btn_DEL_CL_FROM_SH.Location = new System.Drawing.Point(12, 376);
            this.btn_DEL_CL_FROM_SH.Name = "btn_DEL_CL_FROM_SH";
            this.btn_DEL_CL_FROM_SH.Size = new System.Drawing.Size(140, 62);
            this.btn_DEL_CL_FROM_SH.TabIndex = 1;
            this.btn_DEL_CL_FROM_SH.Text = "Видалити Одяг з магазину";
            this.btn_DEL_CL_FROM_SH.UseVisualStyleBackColor = true;
            this.btn_DEL_CL_FROM_SH.Click += new System.EventHandler(this.btn_DEL_CL_FROM_SH_Click);
            // 
            // btn_CHANGE_CLSH
            // 
            this.btn_CHANGE_CLSH.Location = new System.Drawing.Point(201, 376);
            this.btn_CHANGE_CLSH.Name = "btn_CHANGE_CLSH";
            this.btn_CHANGE_CLSH.Size = new System.Drawing.Size(142, 62);
            this.btn_CHANGE_CLSH.TabIndex = 2;
            this.btn_CHANGE_CLSH.Text = "Змiнити Одяг у магазинi";
            this.btn_CHANGE_CLSH.UseVisualStyleBackColor = true;
            this.btn_CHANGE_CLSH.Click += new System.EventHandler(this.btn_CHANGE_CLSH_Click);
            // 
            // fashionHousesDataSet
            // 
            this.fashionHousesDataSet.DataSetName = "FashionHousesDataSet";
            this.fashionHousesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clothesInShopbindingSource
            // 
            this.clothesInShopbindingSource.DataMember = "ClothesInShop";
            this.clothesInShopbindingSource.DataSource = this.fashionHousesDataSet;
            // 
            // clothesInShopTableAdapter
            // 
            this.clothesInShopTableAdapter.ClearBeforeFill = true;
            // 
            // ShowMeClothInShops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.btn_CHANGE_CLSH);
            this.Controls.Add(this.btn_DEL_CL_FROM_SH);
            this.Controls.Add(this.dataGridView_CLSH);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ShowMeClothInShops";
            this.Text = "Одяг у магазинах";
            this.Load += new System.EventHandler(this.ShowMeClothInShops_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CLSH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fashionHousesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clothesInShopbindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_CLSH;
        private System.Windows.Forms.Button btn_DEL_CL_FROM_SH;
        private System.Windows.Forms.Button btn_CHANGE_CLSH;
        private FashionHousesDataSet fashionHousesDataSet;
        private System.Windows.Forms.BindingSource clothesInShopbindingSource;
        private FashionHousesDataSetTableAdapters.ClothesInShopTableAdapter clothesInShopTableAdapter;
    }
}