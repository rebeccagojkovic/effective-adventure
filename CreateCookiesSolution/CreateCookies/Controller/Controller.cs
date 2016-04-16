using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCookies.Controller
{
    public class Controller
    {
        CreateCookiesDataSetTableAdapters.CustomerTableAdapter CDAL = new CreateCookiesDataSetTableAdapters.CustomerTableAdapter();

        public Controller()
        {

        }
        public void RegisterCustomer(string cNumber, string cAddress, string cCountry, string cEmail, string cName, string cPostalAddress)
        {
            CDAL.RegisterCustomerQuery(cNumber, cAddress, cCountry, cEmail, cName, cPostalAddress);
        }
        public void fillComboboxes() {
            string connetionString = null;
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            string sql = null;
            connetionString = "Data Source =.; Initial Catalog = CreateCookies; Integrated Security = True";
            sql = "select cNumber,from Customer";
            connection = new SqlConnection(connetionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close(); 
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
    }
}
