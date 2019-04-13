using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FashionHousesProject
{
    public partial class ChangeDivision : Form
    {
        private int DIV_ID;

        public ChangeDivision(int DIV_ID)
        {
            InitializeComponent();
            this.DIV_ID = DIV_ID;
        }

        private void btn_CHANGE_DIV_Click(object sender, EventArgs e)
        {
            string DIV_ADRESS = textBox_DIV_ADRESS.Text;
            string DIV_NAME = textBox_DIV_NAME.Text;
            int DIV_QTY;

            if (!Int32.TryParse(textBox_DIV_QTY.Text, out DIV_QTY) && textBox_DIV_QTY.Text != String.Empty)
            {
                MessageBox.Show("Iнформацiя про пiдроздiл не змiнилася, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            if(textBox_DIV_QTY.Text != String.Empty && DIV_QTY < 1)
            {
                MessageBox.Show("Iнформацiя про пiдроздiл не змiнилася, помилка вхiдних даних", "Повiдомлення");
                return;
            }

            var Div_to_change = fashionHousesDataSet.Divisions.Rows.Find(DIV_ID);

            if (DIV_NAME != String.Empty)
                Div_to_change["DIV_NAME"] = DIV_NAME;

            if (DIV_ADRESS != String.Empty)
                Div_to_change["DIV_ADRESS"] = DIV_ADRESS;

            if (textBox_DIV_QTY.Text != String.Empty)
                Div_to_change["DIV_QTY"] = DIV_QTY;

            divisionsTableAdapter.Update(fashionHousesDataSet.Divisions);

            MessageBox.Show("Iнформацiя про пiдроздiл успiшно змiнилася", "Повiдомлення");
        }

        private void ChangeDivision_Load(object sender, EventArgs e)
        {
            this.divisionsTableAdapter.Fill(this.fashionHousesDataSet.Divisions);
        }
    }
}
