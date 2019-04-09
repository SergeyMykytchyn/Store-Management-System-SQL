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
    public partial class ShowMeClothInShops : Form
    {
        private int CLSH_CL;

        public ShowMeClothInShops(int CLSH_CL)
        {
            InitializeComponent();
            this.CLSH_CL = CLSH_CL;
        }

        private void ShowClothesInShops()
        {
            string query = "SELECT FH_NAME, SH_ADRESS, SH_QTY_EMP, CLSH_QTY, CLSH_COST, CLSH_ID, SH_ID FROM (ShopClothes INNER JOIN ClothesInShop ON SH_ID = CLSH_SH) INNER JOIN FashionHouses ON SH_FH = FH_ID WHERE CLSH_CL = @CLSH_CL;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, clothesInShopTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@CLSH_CL", CLSH_CL);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridView_CLSH.DataSource = table;

            dataGridView_CLSH.Columns["FH_NAME"].HeaderText = "Дом Моди";
            dataGridView_CLSH.Columns["SH_ADRESS"].HeaderText = "Адрес Магазину";
            dataGridView_CLSH.Columns["SH_QTY_EMP"].HeaderText = "Кiлькiсть Працiвникiв";
            dataGridView_CLSH.Columns["CLSH_QTY"].HeaderText = "Кiлькiсть Одягу у магазинi";
            dataGridView_CLSH.Columns["CLSH_COST"].HeaderText = "Вартiсть одягу у магазинi";
            dataGridView_CLSH.Columns["SH_ID"].Visible = false;
            dataGridView_CLSH.Columns["CLSH_ID"].Visible = false;
        }

        private void ShowMeClothInShops_Load(object sender, EventArgs e)
        {
            this.clothesInShopTableAdapter.Fill(this.fashionHousesDataSet.ClothesInShop);
            ShowClothesInShops();
        }

        private void btn_DEL_CL_FROM_SH_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView_CLSH.CurrentCell.OwningRow;
                int SH_ID = Convert.ToInt32(row.Cells["SH_ID"].Value);

                string query = "DELETE FROM ClothesInShop WHERE CLSH_CL = @CLSH_CL AND CLSH_SH = @SH_ID;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, clothesInShopTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CLSH_CL", CLSH_CL);
                adapter.SelectCommand.Parameters.AddWithValue("@SH_ID", SH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();
                clothesInShopTableAdapter.Update(fashionHousesDataSet.ClothesInShop);

                ShowClothesInShops();
            }
            catch
            {
                return;
            }
        }

        private void btn_CHANGE_CLSH_Click(object sender, EventArgs e)
        {
            try
            {
                int CLSH_ID = Convert.ToInt32(dataGridView_CLSH.CurrentRow.Cells["CLSH_ID"].Value);
                ChangeCLSHForm clsh = new ChangeCLSHForm(CLSH_ID);
                clsh.ShowDialog();

                ShowClothesInShops();
            }
            catch
            {

            }
        }
    }
}
