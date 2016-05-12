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

        public void AddEmployee(DateTime timestamp, string id, string firstName, string middleName, string lastName, string initials, string jobTitle, string searchName, string adress, string adress2, string city, string postCode, string county, string phoneNumber, string mobilePhoneNumber, string eMail, string altAdress, DateTime altAdressStart, DateTime altAdressEnd, string picture, DateTime birthDate, string socialSecurityNumber, string unionCode, string unionMembershipNumber, int sex, string countryRegionCode, string managerNumber, string employmentContractCode, string statisticsGroupCode, DateTime employmentDate, int status, DateTime inactivityDate, string causeOfInactivity, DateTime terminationDate, string groundsForTermCode, string globalDimension1Code, string globalDimension2Code, string resourceNumber, DateTime lastDateModified, string extension, string pager, string faxNumber, string companyEmail, string title, string salesPerPurchCode, string noSeries)
        {
            dal.AddEmployee(timestamp, id, firstName, middleName, lastName, initials, jobTitle, searchName, adress, adress2, city, postCode, county, phoneNumber, mobilePhoneNumber, eMail, altAdress, altAdressStart, altAdressEnd, picture, birthDate, socialSecurityNumber, unionCode, unionMembershipNumber, sex, countryRegionCode, managerNumber, employmentContractCode,  statisticsGroupCode, employmentDate, status, inactivityDate, causeOfInactivity, terminationDate, groundsForTermCode, globalDimension1Code, globalDimension2Code, resourceNumber, lastDateModified, extension, pager, faxNumber, companyEmail, title, salesPerPurchCode, noSeries);
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