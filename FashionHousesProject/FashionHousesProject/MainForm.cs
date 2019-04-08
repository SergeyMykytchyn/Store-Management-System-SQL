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
            // TODO: This line of code loads data into the 'fashionHousesDataSet.Designers' table. You can move, or remove it, as needed.
            this.designersTableAdapter.Fill(this.fashionHousesDataSet.Designers);
            // TODO: This line of code loads data into the 'fashionHousesDataSet.Clothes' table. You can move, or remove it, as needed.
            this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
            // TODO: This line of code loads data into the 'fashionHousesDataSet.FashionHouses' table. You can move, or remove it, as needed.
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
            {
                if ((int)result > 0)
                    return true;
                else return false;
            }
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
    }
}
