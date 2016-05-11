using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace NavWS.DAL
{
    public class DAL
    {
        SqlConnection con = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15");

        public DAL()
        {
        }

        public List<List<string>> SqlConvert(SqlDataReader sqlReader)
        {
            if (sqlReader != null)
            {
                List<List<string>> returnList = new List<List<string>>();

                while (sqlReader.Read())
                {
                    List<string> tmpList = new List<string>();

                    for (int i = 0; i < sqlReader.FieldCount; i++)
                    {
                        string data = "";
                        try
                        {
                            if (sqlReader.GetFieldType(i) == typeof(string))
                            {
                                data = sqlReader.GetString(i);
                            }

                            if (sqlReader.GetFieldType(i) == typeof(int))
                            {
                                int integer = sqlReader.GetInt32(i);
                                data = integer.ToString();
                            }


                        }
                        catch (SqlNullValueException)
                        {
                            data = "null";
                        }

                        tmpList.Add(data);
                    }

                    returnList.Add(tmpList);
                }

                return returnList;
            }

            return null;
        }
        public List<String> ShowAllEmployeesDAL()
        {
            con.Open();

            try
            {
                SqlDataAdapter adapterEmployees = new SqlDataAdapter("SELECT * FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]", con);
                DataSet dt = new DataSet();
                adapterEmployees.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapterEmployees.Fill(dt, "[Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]");

                List<string> EmployeeList = new List<string>();
                foreach (DataRow dataRow in dt.Tables["[Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]"].Rows)
                {
                    EmployeeList.Add(string.Join(", ", dataRow.ItemArray.Select(item => item.ToString())));
                }
                return EmployeeList;
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
        public List<Models.EmployeeModel> ShowAllEmployeesListDAL()
        {
            con.Open();

            try
            {
                List<Models.EmployeeModel> list = new List<Models.EmployeeModel>();

                String query = "SELECT [First_Name] FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeModel();
                    result.First_Name = reader.GetString(0);

                    list.Add(result);

                }
                return list;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                con.Close();
            }

        }
        public List<List<string>> GetEmployees()
        {
            con.Open();
            string sqlQuery = "select top 200 [Employee_No_], [First_Name], [Last_Name] from [CRONUS Sverige AB$Employee]";

            SqlCommand s = new SqlCommand(sqlQuery, con);

            return SqlConvert(s.ExecuteReader());
        }
        public void AddEmployeeDAL(string id, string firstName)
        {
            con.Open();

            try
            {
                SqlDataAdapter adapterEmployees = new SqlDataAdapter("insert into[CRONUS Sverige AB$Employee](No_, [First Name])" + " values (@id, @firstName)", con);
                DataSet dt = new DataSet();
                adapterEmployees.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapterEmployees.Fill(dt, "[Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]");

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void asdasdjlDAL()
        {

        }

    }
}

