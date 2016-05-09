using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Uppgift2
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public List<String> ReadCustomer()
        {

            List<String> list = new List<String>();

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
                    var result = new Customer();
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

    }
}


