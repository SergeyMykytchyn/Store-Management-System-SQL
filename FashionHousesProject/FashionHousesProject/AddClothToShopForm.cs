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
    public partial class AddClothToShopForm : Form
    {
        private int CL_ID;

        public AddClothToShopForm(int CL_ID)
        {
            InitializeComponent();
            this.CL_ID = CL_ID;
        }

        private void AddClothToShopForm_Load(object sender, EventArgs e)
        {
            this.clothesInShopTableAdapter.Fill(this.fashionHousesDataSet.ClothesInShop);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
            this.shopClothesTableAdapter.Fill(this.fashionHousesDataSet.ShopClothes);

            string query = "SELECT * FROM ShopClothes WHERE SH_FH = (SELECT CL_FH FROM Clothes WHERE CL_ID = @CL_ID);";

            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_ID", CL_ID);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_SH_CL.DataSource = table;
        }

        private bool DATA_IS_CORRECT()
        {
            int CLSH_QTY = 0;

            if (!Int32.TryParse(textBox_CLSH_QTY.Text, out CLSH_QTY))
                return false;

            if (CLSH_QTY <= 0)
                return false;

            double CLSH_COST = 0;

            if (!Double.TryParse(textBox_CLSH_COST.Text, out CLSH_COST))
                return false;

            if (CLSH_COST <= 0)
                return false;

            return true;
        }

        private bool CheckForDuplicates(int CLSH_CL, int CLSH_SH)
        {
            string query = "SELECT * FROM ClothesInShop WHERE CLSH_CL = @CLSH_CL AND CLSH_SH = @CLSH_SH;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@CLSH_CL", CLSH_CL);
            adapter.SelectCommand.Parameters.AddWithValue("@CLSH_SH", CLSH_SH);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            return result != null ? (int)result > 0 : false;
        }

        private void btn_add_CL_to_SH_Click(object sender, EventArgs e)
        {
            if (!DATA_IS_CORRECT())
            {
                MessageBox.Show("Одяг не додався до магазину, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            int CLSH_SH;

            try
            {
                var row = dataGridView_SH_CL.CurrentCell.OwningRow;
                CLSH_SH = Convert.ToInt32(row.Cells["sHIDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                MessageBox.Show("Одяг не додався до магазину, бо магазину не iснує", "Повiдомлення");
                return;
            }

            if (CheckForDuplicates(CL_ID, CLSH_SH))
            {
                MessageBox.Show("Такий одяг вже додано до цього магазину, тому вiн не додався", "Повiдомлення");
                return;
            }

            int CLSH_QTY = Int32.Parse(textBox_CLSH_QTY.Text);
            double CLSH_COST = Double.Parse(textBox_CLSH_COST.Text);

            FashionHousesDataSet.ClothesInShopRow newCLSHrow;
            newCLSHrow = fashionHousesDataSet.ClothesInShop.NewClothesInShopRow();
            newCLSHrow.CLSH_CL = CL_ID;
            newCLSHrow.CLSH_SH = CLSH_SH;
            newCLSHrow.CLSH_QTY = CLSH_QTY;
            newCLSHrow.CLSH_COST = (float)CLSH_COST;

            fashionHousesDataSet.ClothesInShop.Rows.Add(newCLSHrow);

            clothesInShopTableAdapter.Update(fashionHousesDataSet.ClothesInShop);

            MessageBox.Show("Одяг додався до магазину", "Повiдомлення");
        }
    }
}
