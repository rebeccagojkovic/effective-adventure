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
using CreateCookies.Model;


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
            // TODO: This line of code loads data into the 'ordeDataSet.Orde' table. You can move, or remove it, as needed.
            this.ordeTableAdapter1.Fill(this.ordeDataSet.Orde);
            // TODO: This line of code loads data into the 'productDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.productDataSet.Product);
            // TODO: This line of code loads data into the 'createCookiesDataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter2.Fill(this.createCookiesDataSet1.Customer);
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
                this.ordeTableAdapter.FindOrder(this.createCookiesDataSet.Orde, searchToolStripTextBoxOrderControl.Text);
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

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection DeleteCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand DeleteCustomerCommand = new SqlCommand("delete from Customer where cNumber='" + comboBoxUCnumber.Text.Trim() + "'", DeleteCustomerConnection);
            if (comboBoxDCnumber.SelectedIndex !=-1)
            {
               DeleteCustomerConnection.Open();
               DeleteCustomerCommand.ExecuteNonQuery();
               DeleteCustomerConnection.Close();
            }

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            SqlConnection SelectCustomerConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15");
            SqlCommand SelectCustommerCommand = new SqlCommand("select * from Customer where cNumber='" + comboBoxUCnumber.Text.Trim() + "'", SelectCustomerConnection);
            SelectCustomerConnection.Open();
            SqlDataReader DR = SelectCustommerCommand.ExecuteReader();
            
            if (DR.Read())
            {
                    if (comboBoxUCnumber.SelectedIndex != -1)
                    {
                        textBoxUCname.Text =DR["cName"].ToString();
                        textBoxUCaddress.Text = DR["cAddress"].ToString();
                        textBoxUCpostaladdress.Text = DR["cPostalAddress"].ToString();
                        comboBoxUCcountry.Text = DR["cCountry"].ToString();
                        textBoxUCemail.Text = DR["cEmail"].ToString();
                    }
                }

                DR.Close();
                SelectCustomerConnection.Close();
            }
        }  
    }


