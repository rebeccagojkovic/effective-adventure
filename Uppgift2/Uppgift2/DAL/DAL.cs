using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Uppgift2.DAL
{
    public class DAL
    {
        SqlConnection sqlConnection;
        public DAL()
        {
        }
        SqlConnection con = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15;");
        public List<Models.Customer> GetCustomerList()
        {
            List<Models.Customer> list = new List<Models.Customer>();

            String connString = @"Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15";
            SqlConnection sqlConn = new SqlConnection(connString);
            sqlConn.Open();

            String query = "SELECT * FROM Customer";
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            SqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    var result = new Models.Customer();
                    result.CNumber = reader.GetString(0);
                    result.CName = reader.GetString(1);
                    result.CAddress = reader.GetString(2);
                    result.CPostalAddress = reader.GetString(3);
                    result.CCountry = reader.GetString(4);
                    result.CEmail = reader.GetString(5);

                    list.Add(result);

                }
            }
            catch (Exception)
            {

                throw;
            }

            return list;

        }
        public List<string> GetCustomers()
        {
            String con = @"Data Source=klippan.privatedns.org;Initial Catalog=CreateCookies;Persist Security Info=True;User ID=grupp15;Password=Grupp15";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Customer", con);
            DataSet ds = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, "Customer");
            List<string> customerList = new List<string>();
            foreach (DataRow dataRow in ds.Tables["Customer"].Rows)
            {
                customerList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            return customerList;
        }
    }
}