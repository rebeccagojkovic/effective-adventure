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
                textBox1.Text = employeeDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                textBox2.Text = employeeDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                textBox3.Text = employeeDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                textBox4.Text = employeeDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                textBox5.Text = employeeDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                textBox6.Text = employeeDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                textBox7.Text = employeeDataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
                string cell8 = employeeDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
                string cell9 = employeeDataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                string cell10 = employeeDataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                string cell11 = employeeDataGridView.SelectedRows[0].Cells[10].Value + string.Empty;
                string cell12 = employeeDataGridView.SelectedRows[0].Cells[11].Value + string.Empty;
                string cell13 = employeeDataGridView.SelectedRows[0].Cells[12].Value + string.Empty;
                string cell14 = employeeDataGridView.SelectedRows[0].Cells[13].Value + string.Empty;
                string cell15 = employeeDataGridView.SelectedRows[0].Cells[14].Value + string.Empty;
                string cell16 = employeeDataGridView.SelectedRows[0].Cells[15].Value + string.Empty;
                string cell17 = employeeDataGridView.SelectedRows[0].Cells[16].Value + string.Empty;


                label1.Text = employeeDataGridView.SelectedRows[0].Cells[0].OwningColumn.Name;
                label2.Text = employeeDataGridView.SelectedRows[0].Cells[1].OwningColumn.Name;
                label3.Text = employeeDataGridView.SelectedRows[0].Cells[2].OwningColumn.Name;
                label4.Text = employeeDataGridView.SelectedRows[0].Cells[3].OwningColumn.Name;
                label5.Text = employeeDataGridView.SelectedRows[0].Cells[4].OwningColumn.Name;
                label6.Text = employeeDataGridView.SelectedRows[0].Cells[5].OwningColumn.Name;
                label7.Text = employeeDataGridView.SelectedRows[0].Cells[6].OwningColumn.Name;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service.DeleteEmployee(employeeDataGridView.SelectedRows[0].Cells[0].Value + string.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            service.UpdateEmployee(textBox1.Text, textBox2.Text);
            employeeDataGridView.DataSource = service.GetEmployees().ToList();
        }
    }
}

