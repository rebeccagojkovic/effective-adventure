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
                textBox8.Text = employeeDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
                textBox9.Text = employeeDataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                textBox10.Text = employeeDataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                textBox11.Text = employeeDataGridView.SelectedRows[0].Cells[10].Value + string.Empty;
                textBox12.Text = employeeDataGridView.SelectedRows[0].Cells[11].Value + string.Empty;
                textBox13.Text = employeeDataGridView.SelectedRows[0].Cells[12].Value + string.Empty;
                textBox14.Text = employeeDataGridView.SelectedRows[0].Cells[13].Value + string.Empty;
                textBox15.Text = employeeDataGridView.SelectedRows[0].Cells[14].Value + string.Empty;
                textBox16.Text = employeeDataGridView.SelectedRows[0].Cells[15].Value + string.Empty;
                textBox17.Text = employeeDataGridView.SelectedRows[0].Cells[16].Value + string.Empty;
                textBox18.Text = employeeDataGridView.SelectedRows[0].Cells[17].Value + string.Empty;
                textBox19.Text = employeeDataGridView.SelectedRows[0].Cells[18].Value + string.Empty;
                textBox20.Text = employeeDataGridView.SelectedRows[0].Cells[19].Value + string.Empty;
                textBox21.Text = employeeDataGridView.SelectedRows[0].Cells[20].Value + string.Empty;
                textBox22.Text = employeeDataGridView.SelectedRows[0].Cells[21].Value + string.Empty;
                textBox23.Text = employeeDataGridView.SelectedRows[0].Cells[22].Value + string.Empty;
                textBox24.Text = employeeDataGridView.SelectedRows[0].Cells[23].Value + string.Empty;
                textBox25.Text = employeeDataGridView.SelectedRows[0].Cells[24].Value + string.Empty;
                textBox26.Text = employeeDataGridView.SelectedRows[0].Cells[25].Value + string.Empty;
                textBox27.Text = employeeDataGridView.SelectedRows[0].Cells[26].Value + string.Empty;
                textBox28.Text = employeeDataGridView.SelectedRows[0].Cells[27].Value + string.Empty;
                textBox29.Text = employeeDataGridView.SelectedRows[0].Cells[28].Value + string.Empty;
                textBox30.Text = employeeDataGridView.SelectedRows[0].Cells[29].Value + string.Empty;
                textBox31.Text = employeeDataGridView.SelectedRows[0].Cells[30].Value + string.Empty;
                textBox32.Text = employeeDataGridView.SelectedRows[0].Cells[31].Value + string.Empty;
                textBox33.Text = employeeDataGridView.SelectedRows[0].Cells[32].Value + string.Empty;
                textBox34.Text = employeeDataGridView.SelectedRows[0].Cells[33].Value + string.Empty;
                textBox35.Text = employeeDataGridView.SelectedRows[0].Cells[34].Value + string.Empty;
                textBox36.Text = employeeDataGridView.SelectedRows[0].Cells[35].Value + string.Empty;
                textBox37.Text = employeeDataGridView.SelectedRows[0].Cells[36].Value + string.Empty;
                textBox38.Text = employeeDataGridView.SelectedRows[0].Cells[37].Value + string.Empty;
                textBox39.Text = employeeDataGridView.SelectedRows[0].Cells[38].Value + string.Empty;
                textBox40.Text = employeeDataGridView.SelectedRows[0].Cells[39].Value + string.Empty;
                textBox41.Text = employeeDataGridView.SelectedRows[0].Cells[40].Value + string.Empty;
                textBox42.Text = employeeDataGridView.SelectedRows[0].Cells[41].Value + string.Empty;
                textBox43.Text = employeeDataGridView.SelectedRows[0].Cells[42].Value + string.Empty;
                textBox44.Text = employeeDataGridView.SelectedRows[0].Cells[43].Value + string.Empty;
                textBox45.Text = employeeDataGridView.SelectedRows[0].Cells[44].Value + string.Empty;




                label1.Text = employeeDataGridView.SelectedRows[0].Cells[0].OwningColumn.Name;
                label2.Text = employeeDataGridView.SelectedRows[0].Cells[1].OwningColumn.Name;
                label3.Text = employeeDataGridView.SelectedRows[0].Cells[2].OwningColumn.Name;
                label4.Text = employeeDataGridView.SelectedRows[0].Cells[3].OwningColumn.Name;
                label5.Text = employeeDataGridView.SelectedRows[0].Cells[4].OwningColumn.Name;
                label6.Text = employeeDataGridView.SelectedRows[0].Cells[5].OwningColumn.Name;
                label7.Text = employeeDataGridView.SelectedRows[0].Cells[6].OwningColumn.Name;
                label8.Text = employeeDataGridView.SelectedRows[0].Cells[7].OwningColumn.Name;
                label9.Text = employeeDataGridView.SelectedRows[0].Cells[8].OwningColumn.Name;
                label10.Text = employeeDataGridView.SelectedRows[0].Cells[9].OwningColumn.Name;
                label11.Text = employeeDataGridView.SelectedRows[0].Cells[10].OwningColumn.Name;
                label12.Text = employeeDataGridView.SelectedRows[0].Cells[11].OwningColumn.Name;
                label13.Text = employeeDataGridView.SelectedRows[0].Cells[12].OwningColumn.Name;
                label14.Text = employeeDataGridView.SelectedRows[0].Cells[13].OwningColumn.Name;
                label15.Text = employeeDataGridView.SelectedRows[0].Cells[14].OwningColumn.Name;
                label16.Text = employeeDataGridView.SelectedRows[0].Cells[15].OwningColumn.Name;
                label17.Text = employeeDataGridView.SelectedRows[0].Cells[16].OwningColumn.Name;
                label18.Text = employeeDataGridView.SelectedRows[0].Cells[17].OwningColumn.Name;
                label19.Text = employeeDataGridView.SelectedRows[0].Cells[18].OwningColumn.Name;
                label20.Text = employeeDataGridView.SelectedRows[0].Cells[19].OwningColumn.Name;
                label21.Text = employeeDataGridView.SelectedRows[0].Cells[20].OwningColumn.Name;
                label22.Text = employeeDataGridView.SelectedRows[0].Cells[21].OwningColumn.Name;
                label23.Text = employeeDataGridView.SelectedRows[0].Cells[22].OwningColumn.Name;
                label24.Text = employeeDataGridView.SelectedRows[0].Cells[23].OwningColumn.Name;
                label25.Text = employeeDataGridView.SelectedRows[0].Cells[24].OwningColumn.Name;
                label26.Text = employeeDataGridView.SelectedRows[0].Cells[25].OwningColumn.Name;
                label27.Text = employeeDataGridView.SelectedRows[0].Cells[26].OwningColumn.Name;
                label28.Text = employeeDataGridView.SelectedRows[0].Cells[27].OwningColumn.Name;
                label29.Text = employeeDataGridView.SelectedRows[0].Cells[28].OwningColumn.Name;
                label30.Text = employeeDataGridView.SelectedRows[0].Cells[29].OwningColumn.Name;
                label31.Text = employeeDataGridView.SelectedRows[0].Cells[30].OwningColumn.Name;
                label32.Text = employeeDataGridView.SelectedRows[0].Cells[31].OwningColumn.Name;
                label33.Text = employeeDataGridView.SelectedRows[0].Cells[32].OwningColumn.Name;
                label34.Text = employeeDataGridView.SelectedRows[0].Cells[33].OwningColumn.Name;
                label35.Text = employeeDataGridView.SelectedRows[0].Cells[34].OwningColumn.Name;
                label36.Text = employeeDataGridView.SelectedRows[0].Cells[35].OwningColumn.Name;
                label37.Text = employeeDataGridView.SelectedRows[0].Cells[36].OwningColumn.Name;
                label38.Text = employeeDataGridView.SelectedRows[0].Cells[37].OwningColumn.Name;
                label39.Text = employeeDataGridView.SelectedRows[0].Cells[38].OwningColumn.Name;
                label40.Text = employeeDataGridView.SelectedRows[0].Cells[39].OwningColumn.Name;
                label41.Text = employeeDataGridView.SelectedRows[0].Cells[40].OwningColumn.Name;
                label42.Text = employeeDataGridView.SelectedRows[0].Cells[41].OwningColumn.Name;
                label43.Text = employeeDataGridView.SelectedRows[0].Cells[42].OwningColumn.Name;
                label44.Text = employeeDataGridView.SelectedRows[0].Cells[43].OwningColumn.Name;
                label45.Text = employeeDataGridView.SelectedRows[0].Cells[44].OwningColumn.Name;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            service.DeleteEmployee(textBox2.Text);
            employeeDataGridView.DataSource = service.GetEmployees();

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            service.UpdateEmployee(textBox2.Text, textBox3.Text);
            employeeDataGridView.DataSource = service.GetEmployees().ToList();
        }

        private void searchEmployeeButton1_Click(object sender, EventArgs e)
        {
            
            employeeDataGridView.DataSource = service.GetEmployee(searchEmployeetextBox.Text);
        }

        private void refreshEmplbutton1_Click(object sender, EventArgs e)
        {
            employeeDataGridView.DataSource = service.GetEmployees();
        }

     
        private void clearNewEmplButton4_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void saveNewEmplButton1_Click(object sender, EventArgs e)
        {
            

            //DateTime timestamp = DateTime.Parse(textBox1.Text);
            DateTime altAdressStart = DateTime.Parse(textBox18.Text);
            DateTime altAdressEnd = DateTime.Parse(textBox19.Text);
            DateTime birthDate = DateTime.Parse(textBox21.Text);
            DateTime employmentDate = DateTime.Parse(textBox30.Text);
            DateTime inactivityDate = DateTime.Parse(textBox32.Text);
            DateTime terminationDate = DateTime.Parse(textBox34.Text);
            DateTime lastDateModified = DateTime.Parse(textBox39.Text);
            int sex = int.Parse(textBox25.Text);
            int status = int.Parse(textBox31.Text);


            service.AddEmployee(textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text, textBox8.Text, textBox9.Text, textBox10.Text, textBox11.Text, textBox12.Text, textBox13.Text, textBox14.Text, textBox15.Text, textBox16.Text, textBox17.Text, altAdressStart, altAdressEnd, textBox20.Text, birthDate, textBox22.Text, textBox23.Text, textBox24.Text, sex, textBox26.Text, textBox27.Text, textBox28.Text, textBox29.Text, employmentDate, status, inactivityDate, textBox33.Text, terminationDate, textBox35.Text, textBox36.Text, textBox37.Text, textBox38.Text, lastDateModified, textBox40.Text, textBox41.Text, textBox42.Text, textBox43.Text, textBox44.Text, textBox45.Text, textBox45.Text);

            employeeDataGridView.DataSource = service.GetEmployees();

        }
    }
}

