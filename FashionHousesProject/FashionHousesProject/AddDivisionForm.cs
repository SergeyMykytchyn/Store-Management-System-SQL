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
    public partial class AddDivisionForm : Form
    {
        private int FH_ID;

        public AddDivisionForm(int FH_ID)
        {
            InitializeComponent();
            this.FH_ID = FH_ID;
        }

        private bool CheckForDuplicates(string DIV_NAME)
        {
            string query = "SELECT DIV_ID FROM Divisions WHERE DIV_NAME = @DIV_NAME;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, divisionsTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@DIV_NAME", DIV_NAME);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            if (result != null)
                return true;
            return false;
        }

        private void btn_DIV_ADD_Click(object sender, EventArgs e)
        {
            string DIV_NAME = textBox_DIV_NAME.Text;
            string DIV_ADRESS = textBox_DIV_ADRESS.Text;
            int DIV_QTY;

            if (DIV_NAME == string.Empty || DIV_ADRESS == String.Empty || !Int32.TryParse(textBox_DIV_QTY.Text, out DIV_QTY) || DIV_QTY < 1)
            {
                MessageBox.Show("Помилка вхiдних даних, пiдроздiл не додано", "Повiдомлення");
                return;
            }

            if (CheckForDuplicates(DIV_NAME))
            {
                MessageBox.Show("Такий пiдроздiл вже існує, пiдроздiл не додано", "Повiдомлення");
                return;
            }

            FashionHousesDataSet.DivisionsRow div;
            div = fashionHousesDataSet.Divisions.NewDivisionsRow();

            div.DIV_NAME = DIV_NAME;
            div.DIV_ADRESS = DIV_ADRESS;
            div.DIV_QTY = DIV_QTY;
            div.DIV_FH = FH_ID;

            fashionHousesDataSet.Divisions.Rows.Add(div);

            divisionsTableAdapter.Update(fashionHousesDataSet.Divisions);

            MessageBox.Show("Пiдроздiл успiшно додано", "Повiдомлення");
        }

        private void AddDivisionForm_Load(object sender, EventArgs e)
        {
            this.divisionsTableAdapter.Fill(this.fashionHousesDataSet.Divisions);
        }
    }
}
