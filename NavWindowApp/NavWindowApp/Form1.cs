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
            this.queryComboBox1.DataSource = cont.GetQueries();
            this.queryComboBox1.DisplayMember = "Name";
            this.queryComboBox1.ValueMember = "Value";
            this.queryComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        localhost.WebService1 service = new localhost.WebService1();
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            queryDataGridView.DataSource = queryComboBox1.SelectedValue;
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView2_VisibleChanged(object sender, EventArgs e)
        {
            employeeDataGridView.DataSource = service.GetEmployees().ToList();
            
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                string cell1 = employeeDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                string cell2 = employeeDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                string label_1 = employeeDataGridView.SelectedRows[0].Cells[0].OwningColumn.Name;
                string label_2 = employeeDataGridView.SelectedRows[0].Cells[1].OwningColumn.Name;
                textBox1.Text = cell1;
                textBox2.Text = cell2;
                label1.Text = label_1;
                label2.Text = label_2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service.DeleteEmployee(employeeDataGridView.SelectedRows[0].Cells[0].Value + string.Empty);
        }
    }
}

