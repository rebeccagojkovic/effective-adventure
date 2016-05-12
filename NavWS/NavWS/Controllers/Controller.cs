using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NavWS.Controllers
{
    public class Controller
    {

      private DAL.DAL dal = new DAL.DAL();

        public Controller()
        {

        }
        //Employee

        public List<String> showAllEmployees()
        {
            return dal.ShowAllEmployeesDAL();
        }
        public List<Models.EmployeeModel> ShowAllEmployeesListDAL()
        {
            return dal.ShowAllEmployeesListDAL();
        }
        public List<List<string>> GetEmployees()
        {
            return dal.GetEmployees();
        }

        public List<List<string>> GetRelative()
        {
            return dal.GetRelative();
        }

        public List<List<string>> GetEmployeeAbsence()
        {
            return dal.GetEmployeeAbsence();
        }

        public List<List<string>> GetSickestEmployee()
        {
            return dal.GetSickestEmployee();
        }

        public List<List<string>> GetKeys()
        {
            return dal.GetKeys();
        }

        public List<List<string>> GetIndexes()
        {
            return dal.GetIndexes();
        }

        public List<List<string>> GetConstraints()
        {
            return dal.GetConstraints();
        }

        public List<List<string>> GetAllTables()
        {
            return dal.GetAllTables();
        }

        public List<List<string>> GetAllTables2()
        {
            return dal.GetAllTables2();
        }

        public List<List<string>> GetEmployeesMeta()
        {
            return dal.GetEmployeesMeta();
        }

        public List<List<string>> GetEmployeesMeta2()
        {
            return dal.GetEmployeesMeta2();
        }

        //---------add/remove/insert/update-------------

        public SqlDataReader GetEmployee(string id)
        {
            return dal.GetEmployee(id);
        }

        public void AddEmployee(string id, string firstName)
        {
            dal.AddEmployee(id, firstName);
        }

        public void DeleteEmployee(string id)
        {
            dal.DeleteEmployee(id);
        }

        public void UpdateEmployee(string id, string firstName)
        {
            dal.UpdateEmployee(id, firstName);
        }

    }
}

//List<string> EmployeeList = new List<string>();
//foreach (DataRow dataRow in ds.Tables["Company"].Rows)
//{
//    EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
//}
//adapter.Fill(ds);