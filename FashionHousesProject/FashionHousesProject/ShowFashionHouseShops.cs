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
    public partial class ShowFashionHouseShops : Form
    {
        private int FH_ID;

        public ShowFashionHouseShops(int FH_ID)
        {
            InitializeComponent();
            this.FH_ID = FH_ID;
        }

        private void UpdateGataGridViewSH()
        {
            string query = "SELECT * FROM ShopClothes WHERE SH_FH = @FH_ID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, shopClothesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridViewSH.DataSource = table;
        }

        private void btn_ADD_SH_Click(object sender, EventArgs e)
        {
            AddShopForm addsh = new AddShopForm(FH_ID);
            addsh.ShowDialog();

            UpdateGataGridViewSH();
        }

        private void ShowFashionHouseShops_Load(object sender, EventArgs e)
        {
            this.shopClothesTableAdapter.Fill(this.fashionHousesDataSet.ShopClothes);
            UpdateGataGridViewSH();
        }

        private void btn_DEL_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int SH_ID = Convert.ToInt32(dataGridViewSH.CurrentRow.Cells["sHIDDataGridViewTextBoxColumn"].Value);

                string query = "DELETE ClothesInShop WHERE CLSH_SH = @SH_ID;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, shopClothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@SH_ID", SH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE ShopClothes WHERE SH_ID = @SH_ID;";
                adapter = new SqlDataAdapter(query, shopClothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@SH_ID", SH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                fashionHousesDataSet.ClothesInShop.AcceptChanges();
                fashionHousesDataSet.ShopClothes.AcceptChanges();

                UpdateGataGridViewSH();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int SH_ID = Convert.ToInt32(dataGridViewSH.CurrentRow.Cells["sHIDDataGridViewTextBoxColumn"].Value);

                ChangeShopForm cgsh = new ChangeShopForm(SH_ID);
                cgsh.ShowDialog();

                UpdateGataGridViewSH();
            }
            catch
            {

            }
        }
    }
}
