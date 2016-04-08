using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCookies
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'createCookiesDataSet.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.createCookiesDataSet.Ingredient);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Orde' table. You can move, or remove it, as needed.
            this.ordeTableAdapter.Fill(this.createCookiesDataSet.Orde);

        }

        private void findOrderToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.ordeTableAdapter.FindOrder(this.createCookiesDataSet.Orde, searchToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
