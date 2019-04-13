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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.presidentsTableAdapter.Fill(this.fashionHousesDataSet.Presidents);
            this.designersTableAdapter.Fill(this.fashionHousesDataSet.Designers);
            this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
        }

        private void dataGridViewCL_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private int get_FH_ID_by_FH_NAME(string FH_NAME)
        {
            string query = "SELECT FH_ID FROM FashionHouses WHERE FH_NAME = @FH_NAME;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_NAME", FH_NAME);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            return (int)result;
        }

        private bool FHexists(string FH_NAME)
        {
            string query = "SELECT FH_ID FROM FashionHouses WHERE FH_NAME = @FH_NAME;";
            SqlDataAdapter FHexists_adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            FHexists_adapter.SelectCommand.Parameters.AddWithValue("@FH_NAME", FH_NAME);
            FHexists_adapter.SelectCommand.Connection.Open();
            var result = FHexists_adapter.SelectCommand.ExecuteScalar();
            FHexists_adapter.SelectCommand.Connection.Close();
            if (result != null)
                return true;
            return false;
        }

        private void btn_CL_Filter_Click(object sender, EventArgs e)
        {
            string CL_FH_NAME = comboBox_CL_FH.Text;
            string CL_DES_NAME = comboBox_CL_DES.Text;
            string CL_CAT = comboBox_CL_CAT.Text;
            string CL_COLOR = comboBox_CL_COLOR.Text;
            int CL_FH = -1;

            if (!FHexists(CL_FH_NAME) && CL_FH_NAME != String.Empty)
            {
                FashionHousesDataSet.ClothesDataTable cl = new FashionHousesDataSet.ClothesDataTable();
                dataGridViewCL.DataSource = cl;
                return;
            }

            string query = "SELECT * FROM Clothes";
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            if (CL_DES_NAME != String.Empty)
            {
                query += " INNER JOIN (SELECT * FROM Designers WHERE Designers.DES_FULLNAME = @DES_NAME) T ON Clothes.CL_DES = T.DES_ID";

            }

            bool firstParameter = true;

            if (CL_FH_NAME != String.Empty)
            {
                if (!firstParameter)
                    query += " AND";
                else {
                    query += " WHERE";
                    firstParameter = false;
                }
                CL_FH = get_FH_ID_by_FH_NAME(CL_FH_NAME);

                query += " CL_FH = @CL_FH";
            }

            if (CL_CAT != String.Empty)
            {
                if (!firstParameter)
                    query += " AND";
                else
                {
                    query += " WHERE";
                    firstParameter = false;
                }
                query += " CL_CATEGORY = @CL_CAT";
            }

            if (CL_COLOR != String.Empty)
            {
                if (!firstParameter)
                    query += " AND";
                else
                {
                    query += " WHERE";
                    firstParameter = false;
                }
                query += " CL_COLOR = @CL_COLOR";
            }

            query += ";";

            adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@DES_NAME", CL_DES_NAME);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_FH", CL_FH);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_CAT", CL_CAT);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_COLOR", CL_COLOR);

            adapter.Fill(table);

            dataGridViewCL.DataSource = table;
        }

        private void btnDelCL_Click(object sender, EventArgs e)
        {
            var row = (DataRowView)clothesBindingSource.Current;
            int CL_ID = (int)row.Row["CL_ID"];
            string query = "DELETE FROM ClothesInShop WHERE CLSH_CL = @CL_ID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
            string con = clothesTableAdapter.Connection.ConnectionString;
            adapter.SelectCommand.Parameters.AddWithValue("@CL_ID", CL_ID);
            adapter.SelectCommand.Connection.Open();
            adapter.SelectCommand.ExecuteNonQuery();
            adapter.SelectCommand.Connection.Close();
            fashionHousesDataSet.ClothesInShop.AcceptChanges();
            clothesBindingSource.RemoveCurrent();
            clothesTableAdapter.Update(fashionHousesDataSet.Clothes);
        }

        private void btnAddCL_Click(object sender, EventArgs e)
        {
            AddClothForm add_cloth_form = new AddClothForm();
            add_cloth_form.ShowDialog();

            clothesTableAdapter.Fill(fashionHousesDataSet.Clothes);
        }

        private void btn_add_CL_to_SH_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridViewCL.CurrentCell.OwningRow;

                int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

                AddClothToShopForm cl_sh = new AddClothToShopForm(CL_ID);
                cl_sh.ShowDialog();
            }
            catch
            {

            }
        }

        private void dataGridViewCL_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var row = dataGridViewCL.CurrentCell.OwningRow;
                int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

                ShowMeClothInShops clsh = new ShowMeClothInShops(CL_ID);
                clsh.ShowDialog();
            }

            catch
            {

            }
        }

        private void btn_Change_CL_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridViewCL.CurrentCell.OwningRow;
                int CL_ID = Convert.ToInt32(row.Cells["cLIDDataGridViewTextBoxColumn"].Value);

                var CLtoChange = fashionHousesDataSet.Clothes.Rows.Find(CL_ID);

                ChangeCloth cgcl = new ChangeCloth(CL_ID, (int)CLtoChange["CL_DES"], (int)CLtoChange["CL_FH"], (string)CLtoChange["CL_DESCRIPTION"], (string)CLtoChange["CL_COLOR"], (string)CLtoChange["CL_CATEGORY"]);
                cgcl.ShowDialog();

                this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
            }
            catch
            {
                return;
            }
        }

        private void button_FH_Filter_Click(object sender, EventArgs e)
        {
            string FH_NAME = comboBox_FH_FH.Text;
            string FH_ADRESS = comboBox_FH_ADRESS.Text;
            string FH_PR = comboBox_FH_PR.Text;

            string query = "SELECT * FROM FashionHouses";
            SqlDataAdapter adapter;
            DataTable table = new DataTable();

            bool firstParameter = true;

            if (FH_PR != String.Empty)
            {
                firstParameter = false;
                query += " INNER JOIN Presidents ON FH_ID = PR_FH WHERE PR_FULLNAME = @PR_FULLNAME ";
            }

            if (FH_NAME != String.Empty)
            {
                if (firstParameter)
                {
                    query += " WHERE ";
                    firstParameter = false;
                }
                else
                    query += " AND";
                query += " FH_NAME = @FH_NAME";
            }

            if (FH_ADRESS != String.Empty)
            {
                if (firstParameter)
                {
                    query += " WHERE ";
                    firstParameter = false;
                }
                else
                    query += " AND";
                query += " FH_ADRESS = @FH_ADRESS";
            }

            query += ";";

            adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@PR_FULLNAME", FH_PR);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_NAME", FH_NAME);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_ADRESS", FH_ADRESS);

            adapter.Fill(table);

            dataGridViewFH.DataSource = table;
        }

        private void UpdateDataGridViewFH()
        {
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
            this.presidentsTableAdapter.Fill(this.fashionHousesDataSet.Presidents);
        }

        private void btnAddFH_Click(object sender, EventArgs e)
        {
            AddFashionHouse fh_form = new AddFashionHouse();
            fh_form.ShowDialog();

            UpdateDataGridViewFH();
        }

        private void UpdateDataGridViewCL()
        {
            this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
        }

        private void btnDelFH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                string query;
                SqlDataAdapter adapter;

                query = "DELETE ClothesInShop FROM ClothesInShop INNER JOIN Clothes ON CLSH_CL = CL_ID WHERE CL_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE Clothes WHERE CL_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE FROM ShopClothes WHERE SH_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE ClothesInShop FROM (ClothesInShop INNER JOIN Clothes ON CLSH_CL = CL_ID) INNER JOIN Designers ON CL_DES = DES_ID WHERE DES_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE Clothes FROM  Clothes INNER JOIN Designers ON CL_DES = DES_ID WHERE DES_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE FROM Designers WHERE DES_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE Divisions WHERE DIV_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE Presidents WHERE PR_FH = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                query = "DELETE FashionHouses WHERE FH_ID = @FH_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                fashionHousesDataSet.ClothesInShop.AcceptChanges();
                fashionHousesDataSet.Clothes.AcceptChanges();
                fashionHousesDataSet.ShopClothes.AcceptChanges();
                fashionHousesDataSet.Designers.AcceptChanges();
                fashionHousesDataSet.Divisions.AcceptChanges();
                fashionHousesDataSet.Presidents.AcceptChanges();
                fashionHousesDataSet.FashionHouses.AcceptChanges();

                UpdateDataGridViewFH();
                UpdateDataGridViewCL();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_FH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                ChangeFashionHouse chfh = new ChangeFashionHouse(FH_ID);
                chfh.ShowDialog();
                UpdateDataGridViewCL();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }

        private void btn_SHOW_SH_Click(object sender, EventArgs e)
        {
            try
            {
                int FH_ID = Convert.ToInt32(dataGridViewFH.CurrentRow.Cells["fHIDDataGridViewTextBoxColumn"].Value);

                ShowFashionHouseShops fhsh = new ShowFashionHouseShops(FH_ID);
                fhsh.ShowDialog();

                UpdateDataGridViewCL();
                UpdateDataGridViewFH();
            }
            catch
            {

            }
        }
    }
}
