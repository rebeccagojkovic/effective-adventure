using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace NavWS.Controllers
{
    public class Controller
    {

        DAL.DAL dal = new DAL.DAL();

        public Controller()
        {

        }


        //Employee
        public void showAllEmployees()
        {
                   
           dal.ShowAllEmployeesDAL();
        }



    }
}

//List<string> EmployeeList = new List<string>();
//foreach (DataRow dataRow in ds.Tables["Company"].Rows)
//{
//    EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
//}
//adapter.Fill(ds);