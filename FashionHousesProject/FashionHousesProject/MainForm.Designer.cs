namespace FashionHousesProject
{
    partial class MainForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageCL = new System.Windows.Forms.TabPage();
            this.btn_Change_CL = new System.Windows.Forms.Button();
            this.btn_add_CL_to_SH = new System.Windows.Forms.Button();
            this.btn_CL_Filter = new System.Windows.Forms.Button();
            this.label_CL_COLOR = new System.Windows.Forms.Label();
            this.label_CL_CAT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CL_DES = new System.Windows.Forms.Label();
            this.label_CL_FH = new System.Windows.Forms.Label();
            this.comboBox_CL_COLOR = new System.Windows.Forms.ComboBox();
            this.comboBox_CL_CAT = new System.Windows.Forms.ComboBox();
            this.comboBox_CL_DES = new System.Windows.Forms.ComboBox();
            this.comboBox_CL_FH = new System.Windows.Forms.ComboBox();
            this.btnDelCL = new System.Windows.Forms.Button();
            this.btnAddCL = new System.Windows.Forms.Button();
            this.dataGridViewCL = new System.Windows.Forms.DataGridView();
            this.tabPageFH = new System.Windows.Forms.TabPage();
            this.tabPageDES = new System.Windows.Forms.TabPage();
            this.btn_SHOW_SH = new System.Windows.Forms.Button();
            this.btn_CHANGE_FH = new System.Windows.Forms.Button();
            this.button_FH_Filter = new System.Windows.Forms.Button();
            this.label_FH_PR = new System.Windows.Forms.Label();
            this.label_FH_ADRESS = new System.Windows.Forms.Label();
            this.comboBox_FH_PR = new System.Windows.Forms.ComboBox();
            this.comboBox_FH_ADRESS = new System.Windows.Forms.ComboBox();
            this.comboBox_FH_FH = new System.Windows.Forms.ComboBox();
            this.label_FH_FH = new System.Windows.Forms.Label();
            this.btnDelFH = new System.Windows.Forms.Button();
            this.btnAddFH = new System.Windows.Forms.Button();
            this.dataGridViewFH = new System.Windows.Forms.DataGridView();
            this.btn_CHANGE_DES = new System.Windows.Forms.Button();
            this.btn_DEL_DES = new System.Windows.Forms.Button();
            this.btn_FILTER = new System.Windows.Forms.Button();
            this.comboBox_DES_BIRTHDAY = new System.Windows.Forms.ComboBox();
            this.comboBox_DES_FH = new System.Windows.Forms.ComboBox();
            this.comboBox_DES_GENDER = new System.Windows.Forms.ComboBox();
            this.comboBox_DES_PASSPORT = new System.Windows.Forms.ComboBox();
            this.comboBox_DES_NAME = new System.Windows.Forms.ComboBox();
            this.label_DES_BIRTHDAY = new System.Windows.Forms.Label();
            this.label_DES_FH = new System.Windows.Forms.Label();
            this.label_DES_GENDER = new System.Windows.Forms.Label();
            this.label_DES_PASSPORT = new System.Windows.Forms.Label();
            this.label_DES_NAME = new System.Windows.Forms.Label();
            this.btn_ADD_DES = new System.Windows.Forms.Button();
            this.dataGridViewDES = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageCL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).BeginInit();
            this.tabPageFH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).BeginInit();
            this.tabPageDES.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDES)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.ErrorImage = null;
            this.pictureBox.Location = new System.Drawing.Point(5, -10);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1065, 325);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageCL);
            this.tabControlMain.Controls.Add(this.tabPageFH);
            this.tabControlMain.Controls.Add(this.tabPageDES);
            this.tabControlMain.Location = new System.Drawing.Point(5, 199);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1076, 565);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageCL
            // 
            this.tabPageCL.Controls.Add(this.btn_Change_CL);
            this.tabPageCL.Controls.Add(this.btn_add_CL_to_SH);
            this.tabPageCL.Controls.Add(this.btn_CL_Filter);
            this.tabPageCL.Controls.Add(this.label_CL_COLOR);
            this.tabPageCL.Controls.Add(this.label_CL_CAT);
            this.tabPageCL.Controls.Add(this.label1);
            this.tabPageCL.Controls.Add(this.label_CL_DES);
            this.tabPageCL.Controls.Add(this.label_CL_FH);
            this.tabPageCL.Controls.Add(this.comboBox_CL_COLOR);
            this.tabPageCL.Controls.Add(this.comboBox_CL_CAT);
            this.tabPageCL.Controls.Add(this.comboBox_CL_DES);
            this.tabPageCL.Controls.Add(this.comboBox_CL_FH);
            this.tabPageCL.Controls.Add(this.btnDelCL);
            this.tabPageCL.Controls.Add(this.btnAddCL);
            this.tabPageCL.Controls.Add(this.dataGridViewCL);
            this.tabPageCL.Location = new System.Drawing.Point(4, 25);
            this.tabPageCL.Name = "tabPageCL";
            this.tabPageCL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCL.Size = new System.Drawing.Size(1068, 536);
            this.tabPageCL.TabIndex = 0;
            this.tabPageCL.Text = "Одяг";
            this.tabPageCL.UseVisualStyleBackColor = true;
            // 
            // btn_Change_CL
            // 
            this.btn_Change_CL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Change_CL.Location = new System.Drawing.Point(928, 353);
            this.btn_Change_CL.Name = "btn_Change_CL";
            this.btn_Change_CL.Size = new System.Drawing.Size(133, 100);
            this.btn_Change_CL.TabIndex = 22;
            this.btn_Change_CL.Text = "Змiнити Одяг";
            this.btn_Change_CL.UseVisualStyleBackColor = true;
            // 
            // btn_add_CL_to_SH
            // 
            this.btn_add_CL_to_SH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_add_CL_to_SH.Location = new System.Drawing.Point(928, 239);
            this.btn_add_CL_to_SH.Name = "btn_add_CL_to_SH";
            this.btn_add_CL_to_SH.Size = new System.Drawing.Size(133, 108);
            this.btn_add_CL_to_SH.TabIndex = 21;
            this.btn_add_CL_to_SH.Text = "Додати одяг до магазину";
            this.btn_add_CL_to_SH.UseVisualStyleBackColor = true;
            // 
            // btn_CL_Filter
            // 
            this.btn_CL_Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CL_Filter.Location = new System.Drawing.Point(928, 34);
            this.btn_CL_Filter.Name = "btn_CL_Filter";
            this.btn_CL_Filter.Size = new System.Drawing.Size(133, 88);
            this.btn_CL_Filter.TabIndex = 20;
            this.btn_CL_Filter.Text = "Вiдфiльтрувати";
            this.btn_CL_Filter.UseVisualStyleBackColor = true;
            // 
            // label_CL_COLOR
            // 
            this.label_CL_COLOR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_CL_COLOR.Location = new System.Drawing.Point(767, 33);
            this.label_CL_COLOR.Name = "label_CL_COLOR";
            this.label_CL_COLOR.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label_CL_COLOR.Size = new System.Drawing.Size(155, 23);
            this.label_CL_COLOR.TabIndex = 19;
            this.label_CL_COLOR.Text = "Колiр";
            this.label_CL_COLOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CL_CAT
            // 
            this.label_CL_CAT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_CL_CAT.Location = new System.Drawing.Point(562, 33);
            this.label_CL_CAT.Name = "label_CL_CAT";
            this.label_CL_CAT.Size = new System.Drawing.Size(155, 23);
            this.label_CL_CAT.TabIndex = 18;
            this.label_CL_CAT.Text = "Категорiя";
            this.label_CL_CAT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // label_CL_DES
            // 
            this.label_CL_DES.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_CL_DES.Location = new System.Drawing.Point(357, 33);
            this.label_CL_DES.Name = "label_CL_DES";
            this.label_CL_DES.Size = new System.Drawing.Size(155, 23);
            this.label_CL_DES.TabIndex = 16;
            this.label_CL_DES.Text = "Дизайнер";
            this.label_CL_DES.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_CL_FH
            // 
            this.label_CL_FH.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label_CL_FH.Location = new System.Drawing.Point(154, 28);
            this.label_CL_FH.Name = "label_CL_FH";
            this.label_CL_FH.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label_CL_FH.Size = new System.Drawing.Size(155, 23);
            this.label_CL_FH.TabIndex = 15;
            this.label_CL_FH.Text = "Дом Моди";
            this.label_CL_FH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_CL_COLOR
            // 
            this.comboBox_CL_COLOR.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_CL_COLOR.FormattingEnabled = true;
            this.comboBox_CL_COLOR.Location = new System.Drawing.Point(767, 76);
            this.comboBox_CL_COLOR.Name = "comboBox_CL_COLOR";
            this.comboBox_CL_COLOR.Size = new System.Drawing.Size(155, 24);
            this.comboBox_CL_COLOR.TabIndex = 14;
            this.comboBox_CL_COLOR.ValueMember = "CL_ID";
            // 
            // comboBox_CL_CAT
            // 
            this.comboBox_CL_CAT.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBox_CL_CAT.FormattingEnabled = true;
            this.comboBox_CL_CAT.Location = new System.Drawing.Point(562, 76);
            this.comboBox_CL_CAT.Margin = new System.Windows.Forms.Padding(100, 3, 100, 3);
            this.comboBox_CL_CAT.Name = "comboBox_CL_CAT";
            this.comboBox_CL_CAT.Size = new System.Drawing.Size(155, 24);
            this.comboBox_CL_CAT.TabIndex = 13;
            this.comboBox_CL_CAT.ValueMember = "CL_ID";
            // 
            // comboBox_CL_DES
            // 
            this.comboBox_CL_DES.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_CL_DES.FormattingEnabled = true;
            this.comboBox_CL_DES.Location = new System.Drawing.Point(356, 76);
            this.comboBox_CL_DES.Margin = new System.Windows.Forms.Padding(1000);
            this.comboBox_CL_DES.Name = "comboBox_CL_DES";
            this.comboBox_CL_DES.Size = new System.Drawing.Size(156, 24);
            this.comboBox_CL_DES.TabIndex = 12;
            this.comboBox_CL_DES.ValueMember = "DES_ID";
            // 
            // comboBox_CL_FH
            // 
            this.comboBox_CL_FH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_CL_FH.FormattingEnabled = true;
            this.comboBox_CL_FH.Location = new System.Drawing.Point(153, 76);
            this.comboBox_CL_FH.Margin = new System.Windows.Forms.Padding(1000);
            this.comboBox_CL_FH.Name = "comboBox_CL_FH";
            this.comboBox_CL_FH.Size = new System.Drawing.Size(156, 24);
            this.comboBox_CL_FH.TabIndex = 11;
            this.comboBox_CL_FH.ValueMember = "FH_ID";
            // 
            // btnDelCL
            // 
            this.btnDelCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelCL.Location = new System.Drawing.Point(928, 128);
            this.btnDelCL.Name = "btnDelCL";
            this.btnDelCL.Size = new System.Drawing.Size(133, 105);
            this.btnDelCL.TabIndex = 10;
            this.btnDelCL.Text = "Видалити Одяг";
            this.btnDelCL.UseVisualStyleBackColor = true;
            // 
            // btnAddCL
            // 
            this.btnAddCL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCL.Location = new System.Drawing.Point(6, 12);
            this.btnAddCL.Name = "btnAddCL";
            this.btnAddCL.Size = new System.Drawing.Size(120, 105);
            this.btnAddCL.TabIndex = 9;
            this.btnAddCL.Text = "Додати Одяг";
            this.btnAddCL.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCL
            // 
            this.dataGridViewCL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCL.Location = new System.Drawing.Point(6, 122);
            this.dataGridViewCL.Name = "dataGridViewCL";
            this.dataGridViewCL.ReadOnly = true;
            this.dataGridViewCL.RowTemplate.Height = 24;
            this.dataGridViewCL.Size = new System.Drawing.Size(916, 401);
            this.dataGridViewCL.TabIndex = 0;
            // 
            // tabPageFH
            // 
            this.tabPageFH.Controls.Add(this.btn_SHOW_SH);
            this.tabPageFH.Controls.Add(this.btn_CHANGE_FH);
            this.tabPageFH.Controls.Add(this.button_FH_Filter);
            this.tabPageFH.Controls.Add(this.label_FH_PR);
            this.tabPageFH.Controls.Add(this.label_FH_ADRESS);
            this.tabPageFH.Controls.Add(this.comboBox_FH_PR);
            this.tabPageFH.Controls.Add(this.comboBox_FH_ADRESS);
            this.tabPageFH.Controls.Add(this.comboBox_FH_FH);
            this.tabPageFH.Controls.Add(this.label_FH_FH);
            this.tabPageFH.Controls.Add(this.btnDelFH);
            this.tabPageFH.Controls.Add(this.btnAddFH);
            this.tabPageFH.Controls.Add(this.dataGridViewFH);
            this.tabPageFH.Location = new System.Drawing.Point(4, 25);
            this.tabPageFH.Name = "tabPageFH";
            this.tabPageFH.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFH.Size = new System.Drawing.Size(1068, 536);
            this.tabPageFH.TabIndex = 1;
            this.tabPageFH.Text = "Дома Моди";
            this.tabPageFH.UseVisualStyleBackColor = true;
            // 
            // btn_SHOW_SH
            // 
            this.btn_SHOW_SH.Location = new System.Drawing.Point(899, 369);
            this.btn_SHOW_SH.Name = "btn_SHOW_SH";
            this.btn_SHOW_SH.Size = new System.Drawing.Size(142, 77);
            this.btn_SHOW_SH.TabIndex = 17;
            this.btn_SHOW_SH.Text = "Магазини Дому Моди";
            this.btn_SHOW_SH.UseVisualStyleBackColor = true;
            // 
            // btn_CHANGE_FH
            // 
            this.btn_CHANGE_FH.Location = new System.Drawing.Point(899, 252);
            this.btn_CHANGE_FH.Name = "btn_CHANGE_FH";
            this.btn_CHANGE_FH.Size = new System.Drawing.Size(142, 96);
            this.btn_CHANGE_FH.TabIndex = 16;
            this.btn_CHANGE_FH.Text = "Змiнити Дом Моди";
            this.btn_CHANGE_FH.UseVisualStyleBackColor = true;
            // 
            // button_FH_Filter
            // 
            this.button_FH_Filter.Location = new System.Drawing.Point(899, 57);
            this.button_FH_Filter.Name = "button_FH_Filter";
            this.button_FH_Filter.Size = new System.Drawing.Size(142, 43);
            this.button_FH_Filter.TabIndex = 15;
            this.button_FH_Filter.Text = "Вiдфiльтрувати";
            this.button_FH_Filter.UseVisualStyleBackColor = true;
            // 
            // label_FH_PR
            // 
            this.label_FH_PR.AutoSize = true;
            this.label_FH_PR.Location = new System.Drawing.Point(725, 42);
            this.label_FH_PR.Name = "label_FH_PR";
            this.label_FH_PR.Size = new System.Drawing.Size(80, 17);
            this.label_FH_PR.TabIndex = 14;
            this.label_FH_PR.Text = "Президент";
            // 
            // label_FH_ADRESS
            // 
            this.label_FH_ADRESS.AutoSize = true;
            this.label_FH_ADRESS.Location = new System.Drawing.Point(461, 42);
            this.label_FH_ADRESS.Name = "label_FH_ADRESS";
            this.label_FH_ADRESS.Size = new System.Drawing.Size(56, 17);
            this.label_FH_ADRESS.TabIndex = 13;
            this.label_FH_ADRESS.Text = "Адреса";
            // 
            // comboBox_FH_PR
            // 
            this.comboBox_FH_PR.FormattingEnabled = true;
            this.comboBox_FH_PR.Location = new System.Drawing.Point(694, 76);
            this.comboBox_FH_PR.Name = "comboBox_FH_PR";
            this.comboBox_FH_PR.Size = new System.Drawing.Size(145, 24);
            this.comboBox_FH_PR.TabIndex = 12;
            // 
            // comboBox_FH_ADRESS
            // 
            this.comboBox_FH_ADRESS.FormattingEnabled = true;
            this.comboBox_FH_ADRESS.Location = new System.Drawing.Point(421, 76);
            this.comboBox_FH_ADRESS.Name = "comboBox_FH_ADRESS";
            this.comboBox_FH_ADRESS.Size = new System.Drawing.Size(146, 24);
            this.comboBox_FH_ADRESS.TabIndex = 11;
            // 
            // comboBox_FH_FH
            // 
            this.comboBox_FH_FH.FormattingEnabled = true;
            this.comboBox_FH_FH.Location = new System.Drawing.Point(190, 76);
            this.comboBox_FH_FH.Name = "comboBox_FH_FH";
            this.comboBox_FH_FH.Size = new System.Drawing.Size(137, 24);
            this.comboBox_FH_FH.TabIndex = 10;
            // 
            // label_FH_FH
            // 
            this.label_FH_FH.AutoSize = true;
            this.label_FH_FH.Location = new System.Drawing.Point(224, 42);
            this.label_FH_FH.Name = "label_FH_FH";
            this.label_FH_FH.Size = new System.Drawing.Size(75, 17);
            this.label_FH_FH.TabIndex = 9;
            this.label_FH_FH.Text = "Дом Моди";
            // 
            // btnDelFH
            // 
            this.btnDelFH.Location = new System.Drawing.Point(899, 116);
            this.btnDelFH.Name = "btnDelFH";
            this.btnDelFH.Size = new System.Drawing.Size(142, 105);
            this.btnDelFH.TabIndex = 2;
            this.btnDelFH.Text = "Видалити Дом Моди";
            this.btnDelFH.UseVisualStyleBackColor = true;
            // 
            // btnAddFH
            // 
            this.btnAddFH.Location = new System.Drawing.Point(6, 6);
            this.btnAddFH.Name = "btnAddFH";
            this.btnAddFH.Size = new System.Drawing.Size(120, 105);
            this.btnAddFH.TabIndex = 1;
            this.btnAddFH.Text = "Додати Дом Моди";
            this.btnAddFH.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFH
            // 
            this.dataGridViewFH.AutoGenerateColumns = false;
            this.dataGridViewFH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFH.Location = new System.Drawing.Point(6, 116);
            this.dataGridViewFH.Name = "dataGridViewFH";
            this.dataGridViewFH.ReadOnly = true;
            this.dataGridViewFH.RowTemplate.Height = 24;
            this.dataGridViewFH.Size = new System.Drawing.Size(878, 401);
            this.dataGridViewFH.TabIndex = 0;
            // 
            // tabPageDES
            // 
            this.tabPageDES.Controls.Add(this.btn_CHANGE_DES);
            this.tabPageDES.Controls.Add(this.btn_DEL_DES);
            this.tabPageDES.Controls.Add(this.btn_FILTER);
            this.tabPageDES.Controls.Add(this.comboBox_DES_BIRTHDAY);
            this.tabPageDES.Controls.Add(this.comboBox_DES_FH);
            this.tabPageDES.Controls.Add(this.comboBox_DES_GENDER);
            this.tabPageDES.Controls.Add(this.comboBox_DES_PASSPORT);
            this.tabPageDES.Controls.Add(this.comboBox_DES_NAME);
            this.tabPageDES.Controls.Add(this.label_DES_BIRTHDAY);
            this.tabPageDES.Controls.Add(this.label_DES_FH);
            this.tabPageDES.Controls.Add(this.label_DES_GENDER);
            this.tabPageDES.Controls.Add(this.label_DES_PASSPORT);
            this.tabPageDES.Controls.Add(this.label_DES_NAME);
            this.tabPageDES.Controls.Add(this.btn_ADD_DES);
            this.tabPageDES.Controls.Add(this.dataGridViewDES);
            this.tabPageDES.Location = new System.Drawing.Point(4, 25);
            this.tabPageDES.Name = "tabPageDES";
            this.tabPageDES.Size = new System.Drawing.Size(1068, 536);
            this.tabPageDES.TabIndex = 2;
            this.tabPageDES.Text = "Дизайнери";
            this.tabPageDES.UseVisualStyleBackColor = true;
            // 
            // btn_CHANGE_DES
            // 
            this.btn_CHANGE_DES.Location = new System.Drawing.Point(938, 259);
            this.btn_CHANGE_DES.Name = "btn_CHANGE_DES";
            this.btn_CHANGE_DES.Size = new System.Drawing.Size(123, 87);
            this.btn_CHANGE_DES.TabIndex = 14;
            this.btn_CHANGE_DES.Text = "Змiнити Iнформацiю про дизайнера";
            this.btn_CHANGE_DES.UseVisualStyleBackColor = true;
            // 
            // btn_DEL_DES
            // 
            this.btn_DEL_DES.Location = new System.Drawing.Point(938, 150);
            this.btn_DEL_DES.Name = "btn_DEL_DES";
            this.btn_DEL_DES.Size = new System.Drawing.Size(123, 76);
            this.btn_DEL_DES.TabIndex = 13;
            this.btn_DEL_DES.Text = "Видалити Дизайнера";
            this.btn_DEL_DES.UseVisualStyleBackColor = true;
            // 
            // btn_FILTER
            // 
            this.btn_FILTER.Location = new System.Drawing.Point(938, 46);
            this.btn_FILTER.Name = "btn_FILTER";
            this.btn_FILTER.Size = new System.Drawing.Size(123, 72);
            this.btn_FILTER.TabIndex = 12;
            this.btn_FILTER.Text = "Вiдфiльтрувати";
            this.btn_FILTER.UseVisualStyleBackColor = true;
            // 
            // comboBox_DES_BIRTHDAY
            // 
            this.comboBox_DES_BIRTHDAY.FormattingEnabled = true;
            this.comboBox_DES_BIRTHDAY.Location = new System.Drawing.Point(781, 82);
            this.comboBox_DES_BIRTHDAY.Name = "comboBox_DES_BIRTHDAY";
            this.comboBox_DES_BIRTHDAY.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_BIRTHDAY.TabIndex = 11;
            // 
            // comboBox_DES_FH
            // 
            this.comboBox_DES_FH.FormattingEnabled = true;
            this.comboBox_DES_FH.Location = new System.Drawing.Point(622, 84);
            this.comboBox_DES_FH.Name = "comboBox_DES_FH";
            this.comboBox_DES_FH.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_FH.TabIndex = 10;
            // 
            // comboBox_DES_GENDER
            //   
            this.comboBox_DES_GENDER.FormattingEnabled = true;
            this.comboBox_DES_GENDER.Location = new System.Drawing.Point(471, 84);
            this.comboBox_DES_GENDER.Name = "comboBox_DES_GENDER";
            this.comboBox_DES_GENDER.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_GENDER.TabIndex = 9;
            // 
            // comboBox_DES_PASSPORT
            // 
            this.comboBox_DES_PASSPORT.FormattingEnabled = true;
            this.comboBox_DES_PASSPORT.Location = new System.Drawing.Point(310, 84);
            this.comboBox_DES_PASSPORT.Name = "comboBox_DES_PASSPORT";
            this.comboBox_DES_PASSPORT.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_PASSPORT.TabIndex = 8;
            // 
            // comboBox_DES_NAME
            // 
            this.comboBox_DES_NAME.FormattingEnabled = true;
            this.comboBox_DES_NAME.Location = new System.Drawing.Point(158, 84);
            this.comboBox_DES_NAME.Name = "comboBox_DES_NAME";
            this.comboBox_DES_NAME.Size = new System.Drawing.Size(121, 24);
            this.comboBox_DES_NAME.TabIndex = 7;
            // 
            // label_DES_BIRTHDAY
            // 
            this.label_DES_BIRTHDAY.AutoSize = true;
            this.label_DES_BIRTHDAY.Location = new System.Drawing.Point(778, 44);
            this.label_DES_BIRTHDAY.Name = "label_DES_BIRTHDAY";
            this.label_DES_BIRTHDAY.Size = new System.Drawing.Size(129, 17);
            this.label_DES_BIRTHDAY.TabIndex = 6;
            this.label_DES_BIRTHDAY.Text = "День Народження";
            // 
            // label_DES_FH
            // 
            this.label_DES_FH.AutoSize = true;
            this.label_DES_FH.Location = new System.Drawing.Point(643, 44);
            this.label_DES_FH.Name = "label_DES_FH";
            this.label_DES_FH.Size = new System.Drawing.Size(75, 17);
            this.label_DES_FH.TabIndex = 5;
            this.label_DES_FH.Text = "Дом Моди";
            // 
            // label_DES_GENDER
            // 
            this.label_DES_GENDER.AutoSize = true;
            this.label_DES_GENDER.Location = new System.Drawing.Point(508, 46);
            this.label_DES_GENDER.Name = "label_DES_GENDER";
            this.label_DES_GENDER.Size = new System.Drawing.Size(34, 17);
            this.label_DES_GENDER.TabIndex = 4;
            this.label_DES_GENDER.Text = "Пол";
            // 
            // label_DES_PASSPORT
            // 
            this.label_DES_PASSPORT.AutoSize = true;
            this.label_DES_PASSPORT.Location = new System.Drawing.Point(337, 46);
            this.label_DES_PASSPORT.Name = "label_DES_PASSPORT";
            this.label_DES_PASSPORT.Size = new System.Drawing.Size(64, 17);
            this.label_DES_PASSPORT.TabIndex = 3;
            this.label_DES_PASSPORT.Text = "Паспорт";
            // 
            // label_DES_NAME
            // 
            this.label_DES_NAME.AutoSize = true;
            this.label_DES_NAME.Location = new System.Drawing.Point(199, 46);
            this.label_DES_NAME.Name = "label_DES_NAME";
            this.label_DES_NAME.Size = new System.Drawing.Size(30, 17);
            this.label_DES_NAME.TabIndex = 2;
            this.label_DES_NAME.Text = "ПIБ";
            // 
            // btn_ADD_DES
            // 
            this.btn_ADD_DES.Location = new System.Drawing.Point(12, 34);
            this.btn_ADD_DES.Name = "btn_ADD_DES";
            this.btn_ADD_DES.Size = new System.Drawing.Size(126, 84);
            this.btn_ADD_DES.TabIndex = 1;
            this.btn_ADD_DES.Text = "Додати Дизайнера";
            this.btn_ADD_DES.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDES
            // 
            this.dataGridViewDES.AutoGenerateColumns = false;
            this.dataGridViewDES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDES.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewDES.Name = "dataGridViewDES";
            this.dataGridViewDES.ReadOnly = true;
            this.dataGridViewDES.RowTemplate.Height = 24;
            this.dataGridViewDES.Size = new System.Drawing.Size(912, 384);
            this.dataGridViewDES.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 753);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.pictureBox);
            this.MaximumSize = new System.Drawing.Size(1100, 800);
            this.MinimumSize = new System.Drawing.Size(1100, 800);
            this.Name = "MainForm";
            this.Text = "Магазин Одягу";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageCL.ResumeLayout(false);
            this.tabPageCL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDES)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageCL;
        private System.Windows.Forms.DataGridView dataGridViewCL;
        private System.Windows.Forms.TabPage tabPageFH;
        private System.Windows.Forms.DataGridView dataGridViewFH;
        private System.Windows.Forms.Button btnAddCL;
        private System.Windows.Forms.Button btnDelCL;
        private System.Windows.Forms.Button btnDelFH;
        private System.Windows.Forms.Button btnAddFH;
        private System.Windows.Forms.ComboBox comboBox_CL_COLOR;
        private System.Windows.Forms.ComboBox comboBox_CL_CAT;
        private System.Windows.Forms.ComboBox comboBox_CL_DES;
        private System.Windows.Forms.ComboBox comboBox_CL_FH;
        private System.Windows.Forms.Label label_CL_FH;
        private System.Windows.Forms.Label label_CL_DES;
        private System.Windows.Forms.Button btn_CL_Filter;
        private System.Windows.Forms.Label label_CL_COLOR;
        private System.Windows.Forms.Label label_CL_CAT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_FH_FH;
        private System.Windows.Forms.ComboBox comboBox_FH_PR;
        private System.Windows.Forms.ComboBox comboBox_FH_ADRESS;
        private System.Windows.Forms.ComboBox comboBox_FH_FH;
        private System.Windows.Forms.Label label_FH_PR;
        private System.Windows.Forms.Label label_FH_ADRESS;
        private System.Windows.Forms.Button button_FH_Filter;
        private System.Windows.Forms.Button btn_add_CL_to_SH;
        private System.Windows.Forms.Button btn_Change_CL;
        private System.Windows.Forms.Button btn_CHANGE_FH;
        private System.Windows.Forms.Button btn_SHOW_SH;
        private System.Windows.Forms.TabPage tabPageDES;
        private System.Windows.Forms.Button btn_CHANGE_DES;
        private System.Windows.Forms.Button btn_DEL_DES;
        private System.Windows.Forms.Button btn_FILTER;
        private System.Windows.Forms.ComboBox comboBox_DES_BIRTHDAY;
        private System.Windows.Forms.ComboBox comboBox_DES_FH;
        private System.Windows.Forms.ComboBox comboBox_DES_GENDER;
        private System.Windows.Forms.ComboBox comboBox_DES_PASSPORT;
        private System.Windows.Forms.ComboBox comboBox_DES_NAME;
        private System.Windows.Forms.Label label_DES_BIRTHDAY;
        private System.Windows.Forms.Label label_DES_FH;
        private System.Windows.Forms.Label label_DES_GENDER;
        private System.Windows.Forms.Label label_DES_PASSPORT;
        private System.Windows.Forms.Label label_DES_NAME;
        private System.Windows.Forms.Button btn_ADD_DES;
        private System.Windows.Forms.DataGridView dataGridViewDES;
    }
}

