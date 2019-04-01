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
    }
}
