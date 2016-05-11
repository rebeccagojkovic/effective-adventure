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

namespace NavWindowApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
        }

        ServiceReference1.GetEmployeesListResponseBody webservice = new ServiceReference1.GetEmployeesListResponseBody();
        localhost.WebService1 service = new localhost.WebService1();
        private void insertButton_Click(object sender, EventArgs e)
        {

            foreach (string s in service.GetEmployees())
            {
                
                richTextBox1.Text += s + "\n";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string[] s in webservice.GetEmployeesListResult)
            {
                dataGridView1.DataSource = webservice.ToString();
                richTextBox1.Text += s + "\n";
            }
            //dataGridView1.DataSource = webservice.ToString();
            //richTextBox1.Text = webservice.ToString();
        }
    }
}

