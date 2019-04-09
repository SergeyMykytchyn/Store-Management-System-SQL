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
    public partial class AddClothForm : Form
    {
        public AddClothForm()
        {
            InitializeComponent();
        }

        private void AddClothForm_Load(object sender, EventArgs e)
        {
            this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
            this.designersTableAdapter.Fill(this.fashionHousesDataSet.Designers);
        }

        private void button_Filter_By_NAME_Click(object sender, EventArgs e)
        {
            string name = comboBox_ENTER_DES_NAME.Text;
            string query;
            if (name != String.Empty)
                query = "SELECT * FROM Designers WHERE DES_FULLNAME = @DES_NAME;";
            else query = "SELECT * FROM Designers;";

            SqlDataAdapter adapter = new SqlDataAdapter(query, designersTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@DES_NAME", name);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dataGridViewDES.DataSource = table;
        }

        private int getFH_ID_by_CL_DES(int CL_DES)
        {
            string query = "SELECT DES_FH FROM Designers WHERE DES_ID = @CL_DES;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_DES", CL_DES);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            return (int)result;
        }

        private bool All_DATA_IS_OK()
        {
            if (textBox_DES.Text == String.Empty || comboBox_CAT.Text == String.Empty || comboBox_COLOR.Text == String.Empty)
                return false;

            return true;
        }

        private bool CheckForDuplicates(int CL_DES, int CL_FH, string CL_DESCRIPTION, string CL_CATEGORY, string CL_COLOR)
        {
            string query = "SELECT * FROM Clothes WHERE CL_DES = @CL_DES AND CL_DESCRIPTION = @CL_DESCRIPTION AND CL_FH = @CL_FH AND CL_CATEGORY = @CL_CATEGORY AND CL_COLOR = @CL_COLOR;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_DES", CL_DES);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_DESCRIPTION", CL_DESCRIPTION);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_FH", CL_FH);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_CATEGORY", CL_CATEGORY);
            adapter.SelectCommand.Parameters.AddWithValue("@CL_COLOR", CL_COLOR);
            adapter.SelectCommand.Connection.Open();
            var result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            return result != null ? (int)result > 0 : false;
        }

        private void button_ADD_CL_Click(object sender, EventArgs e)
        {
            int CL_DES;
            try
            {
                var row = dataGridViewDES.CurrentCell.OwningRow;
                CL_DES = Convert.ToInt32(row.Cells["dESIDDataGridViewTextBoxColumn"].Value);
            }
            catch
            {
                return;
            }

            if (!All_DATA_IS_OK())
            {
                MessageBox.Show("Одяг не додався, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            int CL_FH = getFH_ID_by_CL_DES(CL_DES);
            string CL_DESCRIPTION = textBox_DES.Text;
            string CL_CATEGOTY = comboBox_CAT.Text;
            string CL_COLOR = comboBox_COLOR.Text;

            if (CheckForDuplicates(CL_DES, CL_FH, CL_DESCRIPTION, CL_CATEGOTY, CL_COLOR))
            {
                MessageBox.Show("Такий самий одяг вже додано, тому вiн не додався", "Повiдомлення");
                return;
            }

            FashionHousesDataSet.ClothesRow newCLrow;
            newCLrow = fashionHousesDataSet.Clothes.NewClothesRow();
            newCLrow.CL_DES = CL_DES;
            newCLrow.CL_FH = CL_FH;
            newCLrow.CL_DESCRIPTION = CL_DESCRIPTION;
            newCLrow.CL_CATEGORY = CL_CATEGOTY;
            newCLrow.CL_COLOR = CL_COLOR;

            fashionHousesDataSet.Clothes.Rows.Add(newCLrow);

            clothesTableAdapter.Update(fashionHousesDataSet.Clothes);

            MessageBox.Show("Одяг додався успiшно", "Повiдомлення");

            DialogResult dialogResult = MessageBox.Show("Ви хочете додати одяг до магазину?", "Повiдомлення", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                AddClothToShopForm cl_sh = new AddClothToShopForm(newCLrow.CL_ID);
                cl_sh.ShowDialog();
            }
        }
    }
}
