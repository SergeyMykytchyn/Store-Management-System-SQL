using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FashionHousesProject
{
    public partial class AddShopForm : Form
    {
        private int FH_ID;

        public AddShopForm(int FH_ID)
        {
            InitializeComponent();
            this.FH_ID = FH_ID;
        }

        private bool CheckForDuplicates(string SH_ADRESS, int FH_ID)
        {
            string query = "SELECT SH_ID FROM ShopClothes WHERE SH_ADRESS = @SH_ADRESS AND SH_FH = @FH_ID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, shopClothesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@SH_ADRESS", SH_ADRESS);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            if (result != null)
                return true;
            return false;
        }

        private void btn_ADD_SH_Click(object sender, EventArgs e)
        {
            int SH_QTY_EMP;
            string SH_ADRESS = textBox_SH_ADRESS.Text;

            if (!Int32.TryParse(textBox_SH_QTY_EMP.Text, out SH_QTY_EMP) || SH_ADRESS == String.Empty || SH_QTY_EMP < 1)
            {
                MessageBox.Show("Помилка вхiдних даних, магазин не додано", "Повiдомлення");
                return;
            }

            if (CheckForDuplicates(SH_ADRESS, FH_ID))
            {
                MessageBox.Show("Магазин за такою самою адресою вже існує, магазин не додано", "Повiдомлення");
                return;
            }

            FashionHousesDataSet.ShopClothesRow sh;
            sh = fashionHousesDataSet.ShopClothes.NewShopClothesRow();

            sh.SH_QTY_EMP = SH_QTY_EMP;
            sh.SH_ADRESS = SH_ADRESS;
            sh.SH_FH = FH_ID;

            fashionHousesDataSet.ShopClothes.Rows.Add(sh);
            shopClothesTableAdapter.Update(fashionHousesDataSet.ShopClothes);

            MessageBox.Show("Магазин успiшно додано", "Повiдомлення");
        }

        private void AddShopForm_Load(object sender, EventArgs e)
        {
            this.shopClothesTableAdapter.Fill(this.fashionHousesDataSet.ShopClothes);
        }
    }
}
