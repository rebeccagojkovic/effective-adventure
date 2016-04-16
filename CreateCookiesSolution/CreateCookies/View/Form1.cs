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


namespace CreateCookies
{
    public partial class Form1 : Form
    {
        Controller.Controller controller;
        public Form1(Controller.Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'createCookiesDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.createCookiesDataSet1.Customer);
            // TODO: This line of code loads data into the 'createCookieDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter1.Fill(this.createCookieDataSet1.Customer);
            // TODO: This line of code loads data into the 'createCookieDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.createCookieDataSet.Customer);
            // TODO: This line of code loads data into the 'createCookiesDataSet.Orderspecification' table. You can move, or remove it, as needed.
            this.orderspecificationTableAdapter.Fill(this.createCookiesDataSet.Orderspecification);
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

        private void buttonRegCustomer_Click(object sender, EventArgs e)
        {
            string cNumber = textBoxCnumber.Text;
            string cName = textBoxCname.Text;
            string cAddress = textBoxCaddress.Text;
            string cCountry = comboBoxCcountry.Text;
            string cEmail = textBoxCemail.Text;
            string cPostalAddress = textBoxCpostalAddress.Text;

            controller.RegisterCustomer(cNumber, cAddress, cCountry, cEmail, cName, cPostalAddress);
        }



        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            textBoxCnumber.Clear();
            textBoxCname.Clear();
            textBoxCaddress.Clear();
            textBoxCpostalAddress.Clear();
            comboBoxCcountry.SelectedIndex = -1;
            textBoxCemail.Clear();
            textBoxCnumber.Focus();
        }

        
    }
}

