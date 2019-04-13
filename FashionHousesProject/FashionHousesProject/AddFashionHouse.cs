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
    public partial class AddFashionHouse : Form
    {
        public AddFashionHouse()
        {
            InitializeComponent();
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

        private void btn_ADD_FH_Click(object sender, EventArgs e)
        {
            string FH_NAME = textBox_FH_NAME.Text;
            string FH_ADRESS = textBox_FH_ADRESS.Text;

            string PR_NAME = textBox_PR_NAME.Text;
            int PR_PASSPORT;

            if (FH_NAME == String.Empty || FH_ADRESS == String.Empty || !Int32.TryParse(textBox_PR_PASSPORT.Text, out PR_PASSPORT))
            {
                MessageBox.Show("Помилка вхiдних даних, дом моди не додався", "Повiдомлення");
                return;
            }

            if (!CheckForDuplicates(FH_NAME, PR_PASSPORT))
            {
                MessageBox.Show("Такий дом моди або президент вже iснують, дом моди не додався", "Повiдомлення");
                return;
            }

            FashionHousesDataSet.FashionHousesRow fh;
            fh = fashionHousesDataSet.FashionHouses.NewFashionHousesRow();

            fh.FH_NAME = FH_NAME;
            fh.FH_ADRESS = FH_ADRESS;

            fashionHousesDataSet.FashionHouses.Rows.Add(fh);

            fashionHousesTableAdapter.Update(fashionHousesDataSet.FashionHouses);

            FashionHousesDataSet.PresidentsRow pr;
            pr = fashionHousesDataSet.Presidents.NewPresidentsRow();

            pr.PR_FULLNAME = PR_NAME;
            pr.PR_PASSPORT = PR_PASSPORT;
            pr.PR_FH = fh.FH_ID;

            fashionHousesDataSet.Presidents.Rows.Add(pr);

            presidentsTableAdapter.Update(fashionHousesDataSet.Presidents);

            MessageBox.Show("Дом Моди додався успiшно", "Повiдомлення");
        }

        private void AddFashionHouse_Load(object sender, EventArgs e)
        {
            this.presidentsTableAdapter.Fill(this.fashionHousesDataSet.Presidents);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
        }
    }
}
