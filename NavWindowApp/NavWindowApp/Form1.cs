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
            //foreach (String[] s in service.GetEmployeesList())
            //{
            //    foreach (String item in s)
            //    {
            //        richTextBox1.Text += s + "\n";
            //    }
            //    //dataGridView1.DataSource = s.ToString();
                
            //}
            dataGridView1.DataSource = service.ShowAllEmployeesListDAL().ToList();
            //richTextBox1.Text = webservice.ToString();
        }
    }
}

