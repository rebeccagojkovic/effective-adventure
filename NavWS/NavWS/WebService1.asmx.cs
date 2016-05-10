using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace NavWS
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public List<string> GetEmployees()
        {
            
            String con = @"Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15";
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Company", con);
            DataSet ds = new DataSet();
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            adapter.Fill(ds, "Company");
            List<string> EmployeeList = new List<string>();
            foreach (DataRow dataRow in ds.Tables["Company"].Rows)
            {
                EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
            }
            return EmployeeList;
        }
    }
    }
