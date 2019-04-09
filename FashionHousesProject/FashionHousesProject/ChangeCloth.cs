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
    public partial class ChangeCloth : Form
    {
        private int CL_ID, CL_DES, CL_FH;
        private string CL_DESCRIPTION, CL_COLOR, CL_CATEGORY;

        private void btn_CL_CHANGE_Click(object sender, EventArgs e)
        {
            string CL_DESCRIPTION_ = textBox_DESCRIPTION_TO_CHANGE.Text;
            string CL_COLOR_ = textBox_COLOR_TO_CHANGE.Text;
            string CL_CATEGORY_ = textBox_CAT_TO_CHANGE.Text;

            if (CL_DESCRIPTION_ == String.Empty)
                CL_DESCRIPTION_ = this.CL_DESCRIPTION;

            if (CL_COLOR_ == String.Empty)
                CL_COLOR_ = this.CL_COLOR;

            if (CL_CATEGORY_ == String.Empty)
                CL_CATEGORY_ = this.CL_CATEGORY;

            if ((comboBox_FH_TO_CHANGE.SelectedIndex < 0 && comboBox_FH_TO_CHANGE.Text != String.Empty)
                || (comboBox_DES_TO_CHANGE.SelectedIndex < 0 && comboBox_DES_TO_CHANGE.Text != String.Empty))
            {
                MessageBox.Show("Ви не вибрали Дом моди або Дизайнера, одяг не змiнено", "Повiдомлення");
                return;
            }

            int CL_FH_, CL_DES_;

            if (comboBox_FH_TO_CHANGE.Text != String.Empty)
                CL_FH_ = Convert.ToInt32(comboBox_FH_TO_CHANGE.SelectedValue.ToString());
            else
                CL_FH_ = CL_FH;

            if (comboBox_DES_TO_CHANGE.Text != String.Empty)
                CL_DES_ = Convert.ToInt32(comboBox_DES_TO_CHANGE.SelectedValue.ToString());
            else
                CL_DES_ = CL_DES;

            string query;
            SqlDataAdapter adapter;

            if (this.CL_FH != CL_FH_)
            {
                query = "DELETE FROM ClothesInShop WHERE CLSH_CL = @CL_ID;";
                adapter = new SqlDataAdapter(query, clothesTableAdapter.Connection);
                adapter.SelectCommand.Parameters.AddWithValue("@CL_ID", this.CL_ID);
                adapter.SelectCommand.Connection.Open();
                adapter.SelectCommand.ExecuteNonQuery();
                adapter.SelectCommand.Connection.Close();

                clothesTableAdapter.Update(fashionHousesDataSet.Clothes);
            }

            var CLtoChange = fashionHousesDataSet.Clothes.Rows.Find(this.CL_ID);

            CLtoChange["CL_DES"] = CL_DES_;
            CLtoChange["CL_FH"] = CL_FH_;
            CLtoChange["CL_DESCRIPTION"] = CL_DESCRIPTION_;
            CLtoChange["CL_COLOR"] = CL_COLOR_;
            CLtoChange["CL_CATEGORY"] = CL_CATEGORY_;

            clothesTableAdapter.Update(fashionHousesDataSet.Clothes);
            MessageBox.Show("Одяг успiшно змiнено", "Повiдомлення");
        }

        private void ChangeCloth_Load(object sender, EventArgs e)
        {
            this.designersTableAdapter.Fill(this.fashionHousesDataSet.Designers);
            this.fashionHousesTableAdapter.Fill(this.fashionHousesDataSet.FashionHouses);
            this.clothesTableAdapter.Fill(this.fashionHousesDataSet.Clothes);
        }

        public ChangeCloth(int CL_ID, int CL_DES, int CL_FH, string CL_DESCRIPTION, string CL_COLOR, string CL_CATEGORY)
        {
            InitializeComponent();
            this.CL_ID = CL_ID;
            this.CL_DES = CL_DES;
            this.CL_FH = CL_FH;
            this.CL_DESCRIPTION = CL_DESCRIPTION;
            this.CL_CATEGORY = CL_CATEGORY;
            this.CL_COLOR = CL_COLOR;
        }
    }
}
