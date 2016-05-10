using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NavWS.DAL
{
    public class DAL
    {
        SqlConnection con = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15");

        public DAL()
        {
   //       con.ConnectionString =
   //"user id=grupp15;" +
   //  "password=Grupp15;server=klippan.privatedns.org;" +
   //"Trusted_Connection=yes;" +
   //"database=Demo Database NAV (5-0); " +
   //"connection timeout=30";


        //    String con = @"Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15";

        }


        public void ShowAllEmployeesDAL()
        {
            con.Open();

            try
            {
                SqlDataAdapter adapterEmployees = new SqlDataAdapter("SELECT * FROM Company", con);

                DataSet dt = new DataSet();

                adapterEmployees.Fill(dt);
                List<string> EmployeeList = new List<string>();
                foreach (DataRow dataRow in dt.Tables["Company"].Rows)
                {
                    EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
                }

                //adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                //adapter.Fill(ds, "Company");
                //List<string> EmployeeList = new List<string>();
                //foreach (DataRow dataRow in ds.Tables["Company"].Rows)
                //{
                //    EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
                //}
                //adapter.Fill(ds);


                //SqlDataAdapter SeeAllOrdersAdapter = new SqlDataAdapter("Select * from Orde where cNumber= '" + cNumber + "'", connection);
                //DataTable dt = new DataTable();
                //SeeAllOrdersAdapter.Fill(dt);
            }
            catch (Exception Ex)
            {
                throw Ex;
            }

            finally
            {
                con.Close();
            }
        }

    }
}

