﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionHousesProject
{
    public partial class ChangeShopForm : Form
    {
        private int SH_ID;

        public ChangeShopForm(int SH_ID)
        {
            InitializeComponent();
            this.SH_ID = SH_ID;
        }

        private void btn_CHANGE_SH_Click(object sender, EventArgs e)
        {
            string SH_ADRESS = textBox_SH_ADRESS.Text;
            string SH_QTY_EMP_str = textBox_SH_QTY_EMP.Text;

            var SHToChange = fashionHousesDataSet.ShopClothes.Rows.Find(SH_ID);

            if (SH_ADRESS != String.Empty)
                SHToChange["SH_ADRESS"] = SH_ADRESS;

            if (SH_QTY_EMP_str != String.Empty)
            {
                int SH_QTY_EMP;
                if (!Int32.TryParse(SH_QTY_EMP_str, out SH_QTY_EMP) || SH_QTY_EMP < 1)
                {
                    MessageBox.Show("Помилка вхiдних даних, магазин не змiнено", "Повiдомлення");
                    return;
                }

                SHToChange["SH_QTY_EMP"] = SH_QTY_EMP;
            }

            shopClothesTableAdapter.Update(fashionHousesDataSet.ShopClothes);

            MessageBox.Show("Магазин успiшно змiнено", "Повiдомлення");
        }

        private void ChangeShopForm_Load(object sender, EventArgs e)
        {
            this.shopClothesTableAdapter.Fill(this.fashionHousesDataSet.ShopClothes);
        }
    }
}
