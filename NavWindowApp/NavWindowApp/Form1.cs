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

        Controller.Controller controller;
        public Form1(Controller.Controller controller)
        {
            this.controller = controller;
            InitializeComponent();
        }



        private void insertButton_Click(object sender, EventArgs e)
        {
            SqlConnection InsertEmployeeConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15");

            SqlCommand InsertEmployeeCommand = new SqlCommand("insert into Employee (No_) values (@No_)", InsertEmployeeConnection);

            InsertEmployeeCommand.Parameters.AddWithValue("@No_", textBox1.Text);


            InsertEmployeeConnection.Open();
            InsertEmployeeCommand.ExecuteNonQuery();
            InsertEmployeeConnection.Close();
        }
    }
}


public class DAL
{
    SqlConnection con = new SqlConnection();

    public DAL()
    {
        con.ConnectionString =
"user id=cronus;" +
"password=cronus;server=localhost;" +
"Trusted_Connection=yes;" +
"database=Demo Database NAV (5-0); " +
"connection timeout=30";
    }