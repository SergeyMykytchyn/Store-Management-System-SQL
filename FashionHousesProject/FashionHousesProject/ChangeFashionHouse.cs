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
    public partial class ChangeFashionHouse : Form
    {
        private int FH_ID;

        public ChangeFashionHouse(int FH_ID)
        {
            InitializeComponent();
            this.FH_ID = FH_ID;
        }

        private bool CheckForDuplicates(string FH_NAME, int PR_PASSPORT)
        {
            object result;

            string query = "SELECT FH_ID FROM FashionHouses WHERE FH_NAME = @FH_NAME;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_NAME", FH_NAME);
            adapter.SelectCommand.Connection.Open();
            result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            if (result != null)
                return false;

            query = "SELECT PR_ID FROM Presidents WHERE PR_PASSPORT = @PR_PASSPORT;";
            adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@PR_PASSPORT", PR_PASSPORT);
            adapter.SelectCommand.Connection.Open();
            result = adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            if (result != null)
                return false;

            return true;
        }

        private int get_PR_ID_by_FH_ID(int FH_ID)
        {
            string query = "SELECT PR_ID FROM Presidents WHERE PR_FH = @FH_ID;";
            SqlDataAdapter adapter = new SqlDataAdapter(query, fashionHousesTableAdapter.Connection);
            adapter.SelectCommand.Parameters.AddWithValue("@FH_ID", FH_ID);
            adapter.SelectCommand.Connection.Open();
            int result = (int)adapter.SelectCommand.ExecuteScalar();
            adapter.SelectCommand.Connection.Close();
            return result;
        }

        private void btn_FH_CHANGE_Click(object sender, EventArgs e)
        {
            string FH_NAME = textBox_FH_NAME.Text;
            string FH_ADRESS = textBox_FH_ADRESS.Text;
            string PR_NAME = textBox_PR_NAME.Text;
            int PR_PASSPORT = 0;

            if (textBox_PR_PASSPORT.Text != String.Empty && !Int32.TryParse(textBox_PR_PASSPORT.Text, out PR_PASSPORT))
            {
                MessageBox.Show("Помилка вхiдних даних, дом моди не переiменовано", "Повiдомлення");
                return;
            }

            if (!CheckForDuplicates(FH_NAME, PR_PASSPORT))
            {
                MessageBox.Show("Такий дом моди або президент вже iснують, дом моди не переiменовано", "Повiдомлення");
                return;
            }

            int PR_ID = get_PR_ID_by_FH_ID(FH_ID);

            var FHToChange = fashionHousesDataSet.FashionHouses.Rows.Find(FH_ID);
            var PRToChange = fashionHousesDataSet.Presidents.Rows.Find(PR_ID);

            if (textBox_PR_PASSPORT.Text != String.Empty)
                PRToChange["PR_PASSPORT"] = PR_PASSPORT;

            if (PR_NAME != String.Empty)
                PRToChange["PR_FULLNAME"] = PR_NAME;

            if (FH_NAME != String.Empty)
                FHToChange["FH_NAME"] = FH_NAME;

            if (FH_ADRESS != String.Empty)
                FHToChange["FH_ADRESS"] = FH_ADRESS;

            fashionHousesTableAdapter.Update(fashionHousesDataSet.FashionHouses);
            presidentsTableAdapter.Update(fashionHousesDataSet.Presidents);
            MessageBox.Show("Дом моди успiшно змiнено", "Повiдомлення");
        }

        private void ChangeFashionHouse_Load(object sender, EventArgs e)
        {
            this.presidentsTableAdapter.Fill(this.fashionHousesDataSet.Presidents);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
        }
    }
}
