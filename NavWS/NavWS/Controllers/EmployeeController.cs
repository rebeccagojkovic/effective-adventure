using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace NavWS.Controllers
{
    public class EmployeeController
    {

        private Models.Employee model = new Models.Employee();
        DAL.DAL dal = new DAL.DAL();




        //public List<string> GetEmployees()
        //{
        //    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Company", @"Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15");
        //    DataSet ds = new DataSet();
        //    adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;
        //    adapter.Fill(ds, "Company");
        //    List<string> EmployeeList = new List<string>();
        //    foreach (DataRow dataRow in ds.Tables["Company"].Rows)
        //    {
        //        EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
        //    }
        //    return EmployeeList;
        //}
        
    }
    }
