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
    public partial class ShowDivisionsForm : Form
    {
        private int FH_ID;

        public ShowDivisionsForm(int FH_ID)
        {
            InitializeComponent();
            this.FH_ID = FH_ID;
        }

        private void ShowDivisionsForm_Load(object sender, EventArgs e)
        {
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
            this.divisionsTableAdapter.Fill(this.fashionHousesDataSet.Divisions);
            UpdateDataGridViewDiv();
        }

        private void UpdateDataGridViewDiv()
        {
            string query = "SELECT * FROM Divisions WHERE DIV_FH = @FH_ID";
            SqlDataAdapter adapter = new SqlDataAdapter(query, divisionsTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridViewDIV.DataSource = table;
        }

        private void btn_ADD_DIV_Click(object sender, EventArgs e)
        {
            AddDivisionForm add_div = new AddDivisionForm(FH_ID);
            add_div.ShowDialog();

            UpdateDataGridViewDiv();
        }

        private void btn_DEL_DIV_Click(object sender, EventArgs e)
        {
            try
            {
                int DIV_ID = Convert.ToInt32(dataGridViewDIV.CurrentRow.Cells["dIVIDDataGridViewTextBoxColumn"].Value);

                string query = "DELETE Divisions WHERE DIV_ID = @DIV_ID;";
                SqlDataAdapter adapter = new SqlDataAdapter(query, divisionsTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@DIV_ID", DIV_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                fashionHousesDataSet.Divisions.AcceptChanges();

                UpdateDataGridViewDiv();
            }
            catch
            {

            }
        }

        private void btn_CHANGE_DIV_Click(object sender, EventArgs e)
        {
            try
            {
                int DIV_ID = Convert.ToInt32(dataGridViewDIV.CurrentRow.Cells["dIVIDDataGridViewTextBoxColumn"].Value);

                ChangeDivision cgdiv = new ChangeDivision(DIV_ID);
                cgdiv.ShowDialog();

                UpdateDataGridViewDiv();
            }
            catch
            {

            }
        }
    }
}
