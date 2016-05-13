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


            Controllers.Controller cont = new Controllers.Controller();
            this.comboBox1.DataSource = cont.GetQueries();
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.ValueMember = "Value";
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        localhost.WebService1 service = new localhost.WebService1();
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = comboBox1.SelectedValue;
        }

       
    }
}

