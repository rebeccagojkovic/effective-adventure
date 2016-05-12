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
       
        SqlConnection sqlConnection;
        public DAL()
        {
        }
        public void Connect()
        {
            sqlConnection = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15;");
            sqlConnection.Open();
        }
        SqlConnection con = new SqlConnection("Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15;");


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
            Connect();

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
              
            }

        }
        public List<List<string>> GetEmployees()
        {
            Connect();
            string sqlQuery = "select top 200 [Employee_No_], [First_Name], [Last_Name] from [CRONUS Sverige AB$Employee]";

            SqlCommand s = new SqlCommand(sqlQuery, con);

            return SqlConvert(s.ExecuteReader());
        }
        public void AddEmployeeDAL(string id, string firstName)
        {
            Connect();

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
        //1a lösningen
        public List<List<string>> GetEmployeesMeta()
        {
            Connect();

            string sqlQuery = "select Table_Name, Column_name from INFORMATION_SCHEMA.COLUMNS where"
                + " TABLE_NAME = 'CRONUS Sverige AB$Employee'";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        //2a lösningen
        public List<List<string>> GetEmployeesMeta2()
        {
            Connect();

            string sqlQuery = "SELECT b.name, a.name FROM sys.columns a JOIN sys.tables b ON a.object_id"
                + " = b.object_id WHERE b.name LIKE 'CRONUS Sverige AB$Employee'";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        public List<List<string>> GetRelative()
        {
            Connect();
            string sqlQuery = "select a.[Employee No_],a.[Relative Code],a.[First Name],b.[First Name]"
                + " from [CRONUS Sverige AB$Employee Relative] a inner join [CRONUS Sverige AB$Employee]"
                + " b on a.[Employee No_]=b.[No_]";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        public List<List<string>> GetEmployeeAbsence()
        {
            Connect();
            string sqlQuery = "select a.[Employee No_], a.Description from [CRONUS Sverige AB$Employee Absence]"
                + " a where a.[From Date] < CONVERT(DateTime, '2004-12-31 12:00:00.000') and"
                + " a.[From Date] > CONVERT(DateTime, '2004-01-01 00:00:00.000') and"
                + " a.[Cause of Absence Code] = 'SJUK'";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        public List<List<string>> GetSickestEmployee()
        {
            Connect();
            string sqlQuery = "select top 1 a.[First Name] from [CRONUS Sverige AB$Employee] a inner join"
                + " [CRONUS Sverige AB$Employee Absence] b on a.No_= b.[Employee No_] and b.[Cause of Absence Code]"
                + " = 'SJUK' group by a.[First Name] order by count(*) desc";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        //---------------------- Add/Delete/Insert/Update SQL ----------------------

        public SqlDataReader GetEmployee(string id)
        {
            Connect();
            string sqlQuery = "select a.No_, a.[First Name], a.[Last Name] from"
                + " [CRONUS Sverige AB$Employee] a where a.No_ = @id";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);
            s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;

            return s.ExecuteReader();
        }

        public void AddEmployee(string id, string firstName)
        {
            Connect();
            string sqlQuery = "insert into [CRONUS Sverige AB$Employee] (No_, [First Name])"
                + " values (@id, @firstName)";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;
            s.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;

            try
            {
                s.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                //Primary konflikt
            }
        }

        public void DeleteEmployee(string id)
        {
            Connect();
            string sqlQuery = "delete from [CRONUS Sverige AB$Employee] where No_ = @id";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;

            try
            {
                s.ExecuteNonQuery();
            }
            catch (SqlException)
            {

            }


        }

        public void UpdateEmployee(string id, string firstName)
        {
            Connect();
            string sqlQuery = "update [CRONUS Sverige AB$Employee] SET [First Name] = @firstName where No_ = @id";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;
            s.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;

            try
            {
                s.ExecuteNonQuery();
            }
            catch (SqlException)
            {

            }


        }



        //-------------------SQL METADATA Uppgifter--------------------
        public List<List<string>> GetKeys()
        {
            Connect();

            string sqlQuery = "select top 100 CONSTRAINT_NAME from INFORMATION_SCHEMA.KEY_COLUMN_USAGE";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        public List<List<string>> GetIndexes()
        {
            Connect();

            string sqlQuery = "select top 100 a.object_id, a.name from sys.indexes a where a.name like 'CRONUS%'";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        public List<List<string>> GetConstraints()
        {
            Connect();

            string sqlQuery = "select top 100 CONSTRAINT_NAME, TABLE_NAME from INFORMATION_SCHEMA.TABLE_CONSTRAINTS";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        //Alla tables i databasen
        //1a lösningen
        public List<List<string>> GetAllTables()
        {
            Connect();

            string sqlQuery = "select top 100 a.TABLE_NAME from INFORMATION_SCHEMA.TABLES a";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

        //2a lösningen
        public List<List<string>> GetAllTables2()
        {
            Connect();

            string sqlQuery = "select top 100 a.name from sys.tables a;";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        }

     

    }
}

