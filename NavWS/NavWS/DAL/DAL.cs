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
        public List<Models.EmployeeModel> GetAllEmployeesList()
        {
            con.Open();
            try
            {
                List<Models.EmployeeModel> list = new List<Models.EmployeeModel>();

                String query = "SELECT [Employee_No_], [First_Name], [Last_Name] FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeModel();
                    result.Employee_No_ = reader.GetString(0);
                    result.First_Name = reader.GetString(1);
                    result.Last_Name = reader.GetString(2);

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

        public List<Models.EmployeeMeta> GetEmployeesMeta()
        {
            con.Open();
            try
            {
                List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                String query = "SELECT Table_Name, Column_name from INFORMATION_SCHEMA.COLUMNS where TABLE_NAME = 'CRONUS Sverige AB$Employee'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeMeta();
                    result.Table_Name = reader.GetString(0);
                    result.Column_Name = reader.GetString(1);
                    
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
        //1a lösningen
        public List<List<string>> GetEmployeesMetaold()
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
            string sqlQuery = "select top 1 a.[First_Name] from [CRONUS Sverige AB$Employee] a inner join"
                + " [CRONUS Sverige AB$Employee Absence] b on a.No_= b.[Employee_No_] and b.[Cause_of_Inactivity Code]"
                + " = 'SJUK' group by a.[First_Name] order by count(*) desc";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            return SqlConvert(s.ExecuteReader());
        

        }

        //---------------------- Add/Delete/Insert/Update SQL ----------------------

        public SqlDataReader GetEmployee(string id)
        {

            con.Open();

            try
            {
                string sqlQuery = "select a.No_, a.[First_Name], a.[Last_Name] from"
                    + " [CRONUS Sverige AB$Employee] a where a.No_ = @id";

                SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);
                s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;

                return s.ExecuteReader();
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

        public void AddEmployee(DateTime timestamp, string id, string firstName, string middleName, string lastName, string initials, string jobTitle, string searchName, string adress, string adress2, string city, string postCode, string county, string phoneNumber, string mobilePhoneNumber, string eMail, string altAdress, DateTime altAdressStart, DateTime altAdressEnd, string picture, DateTime birthDate, string socialSecurityNumber, string unionCode, string unionMembershipNumber, int sex, string countryRegionCode, string managerNumber, string employmentContractCode, string statisticsGroupCode, DateTime employmentDate, int status, DateTime inactivityDate, string causeOfInactivity, DateTime terminationDate, string groundsForTermCode, string globalDimension1Code, string globalDimension2Code, string resourceNumber, DateTime lastDateModified, string extension, string pager, string faxNumber, string companyEmail, string title, string salesPerPurchCode, string noSeries)
        {
            Connect() ;
            string sqlQuery = "INSERT INTO [dbo].[CRONUS Sverige AB$Employee]([Employee_No_],[First_Name],[Middle_Name],[Last_Name],[Initials],[Job_Title],[Search_Name],[Address],[Address 2],[City],[Post_Code],[County],[Phone_No_],[Mobile_PhoneNo_],[E - Mail],[Alt_ Address Code],[Alt_ Address Start Date],[Alt_ Address End Date],[Picture],[Birth_Date],[Social_Security No_],[Union_Code],[Union_Membership No_],[Sex],[Country_Region Code],[Manager_No_],[Emplymt_ Contract Code],[Statistics_Group_Code],[Employment_Date],[Status],[Inactive_Date],[Cause_of_Inactivity Code],[Termination_Date],[Grounds for Term_ Code],[Global Dimension 1 Code],[Global Dimension 2 Code],[Resource No_],[Last Date Modified],[Extension],[Pager],[Fax No_],[Company E - Mail],[Title],[Salespers__Purch_ Code],[No_ Series]) "
                     + "VALUES (< Employee_No_, varchar(20),> ,< First_Name, varchar(30),> ,< Middle_Name, varchar(30),>,< Last_Name, varchar(30),>,< Initials, varchar(30),>,< Job_Title, varchar(30),>,< Search_Name, varchar(30),>,< Address, varchar(50),>,< Address 2, varchar(50),>,< City, varchar(30),>,< Post_Code, varchar(20),>,< County, varchar(30),>,< Phone_No_, varchar(30),>,< Mobile_PhoneNo_, varchar(30),>,< E - Mail, varchar(80),>,< Alt_ Address Code, varchar(10),>,< Alt_ Address Start Date, datetime,>,< Alt_ Address End Date, datetime,>,< Picture, image,>,< Birth_Date, datetime,>,< Social_Security No_, varchar(30),>,< Union_Code, varchar(10),>,< Union_Membership No_, varchar(30),>,< Sex, int,>,< Country_Region Code, varchar(10),>,< Manager_No_, varchar(20),>,< Emplymt_ Contract Code, varchar(10),>,< Statistics_Group_Code, varchar(10),>,< Employment_Date, datetime,>,< Status, int,>,< Inactive_Date, datetime,>,< Cause_of_Inactivity Code, varchar(10),>< Termination_Date, datetime,>,< Grounds for Term_ Code, varchar(10),>,< Global Dimension 1 Code, varchar(20),>< Global Dimension 2 Code, varchar(20),>,< Resource No_, varchar(20),>,< Last Date Modified, datetime,>,< Extension, varchar(30),>,< Pager, varchar(30),>,< Fax No_, varchar(30),>,< Company E - Mail, varchar(80),>,< Title, varchar(30),>,< Salespers__Purch_ Code, varchar(10),>,< No_ Series, varchar(10),>) ";


                SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);
                s.Parameters.Add("@timestamp", SqlDbType.Bit, 30).Value = timestamp;
                s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;
                s.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;
                s.Parameters.Add("@middleName", SqlDbType.VarChar, 30).Value = middleName;
                s.Parameters.Add("@lastName", SqlDbType.VarChar, 30).Value = lastName;
                s.Parameters.Add("@initials", SqlDbType.VarChar, 30).Value = initials;
                s.Parameters.Add("@jobTitle", SqlDbType.VarChar, 30).Value = jobTitle;
                s.Parameters.Add("@searchName", SqlDbType.VarChar, 30).Value = searchName;
                s.Parameters.Add("@adress", SqlDbType.VarChar, 30).Value = adress;
                s.Parameters.Add("@adress2", SqlDbType.VarChar, 30).Value = adress2;
                s.Parameters.Add("@city", SqlDbType.VarChar, 30).Value = city;
                s.Parameters.Add("@postCode", SqlDbType.VarChar, 30).Value = postCode;
                s.Parameters.Add("@county", SqlDbType.VarChar, 30).Value = county;
                s.Parameters.Add("@phoneNumber", SqlDbType.VarChar, 30).Value = phoneNumber;
                s.Parameters.Add("@mobilePhoneNumber", SqlDbType.VarChar, 30).Value = mobilePhoneNumber;
                s.Parameters.Add("@eMail", SqlDbType.VarChar, 30).Value = eMail;
                s.Parameters.Add("@altAdressCode", SqlDbType.VarChar, 30).Value = altAdress;
                s.Parameters.Add("@altAdressStart", SqlDbType.DateTime, 30).Value = altAdressStart;
                s.Parameters.Add("@altAdressEnd", SqlDbType.DateTime, 30).Value = altAdressEnd;
                s.Parameters.Add("@picture", SqlDbType.VarChar, 30).Value = picture;
                s.Parameters.Add("@birthDate", SqlDbType.DateTime, 30).Value = birthDate;
                s.Parameters.Add("@socialSecurityNumber", SqlDbType.VarChar, 30).Value = socialSecurityNumber;
                s.Parameters.Add("@unionCode", SqlDbType.VarChar, 30).Value = unionCode;
                s.Parameters.Add("@unionMembershipNumber", SqlDbType.VarChar, 30).Value = unionMembershipNumber;
                s.Parameters.Add("@sex", SqlDbType.Int, 30).Value = sex;
                s.Parameters.Add("@countryRegionCode", SqlDbType.VarChar, 30).Value = countryRegionCode;
                s.Parameters.Add("@managerNumber", SqlDbType.VarChar, 30).Value = managerNumber;
                s.Parameters.Add("@employmentContractCode", SqlDbType.VarChar, 30).Value = employmentContractCode;
                s.Parameters.Add("@statisticsGroupCode", SqlDbType.VarChar, 30).Value = statisticsGroupCode;
                s.Parameters.Add("@employmentDate", SqlDbType.DateTime, 30).Value = employmentDate;
                s.Parameters.Add("@status", SqlDbType.VarChar, 30).Value = status;
                s.Parameters.Add("@inactivityDate", SqlDbType.DateTime, 30).Value = inactivityDate;
                s.Parameters.Add("@causeOfInactivity", SqlDbType.VarChar, 30).Value = causeOfInactivity;
                s.Parameters.Add("@terminationDate", SqlDbType.DateTime, 30).Value = terminationDate;
                s.Parameters.Add("@groundsForTermCode", SqlDbType.VarChar, 30).Value = groundsForTermCode;
                s.Parameters.Add("@globalDimension1Code", SqlDbType.VarChar, 30).Value = globalDimension1Code;
                s.Parameters.Add("@globalDimension2Code", SqlDbType.VarChar, 30).Value = globalDimension2Code;
                s.Parameters.Add("@resourceNumber", SqlDbType.VarChar, 30).Value = resourceNumber;
                s.Parameters.Add("@lastDateModified", SqlDbType.DateTime, 30).Value = lastDateModified;
                s.Parameters.Add("@extension", SqlDbType.VarChar, 30).Value = extension;
                s.Parameters.Add("@pager", SqlDbType.VarChar, 30).Value = pager;
                s.Parameters.Add("@faxNumber", SqlDbType.VarChar, 30).Value = faxNumber;
                s.Parameters.Add("@companyEmail", SqlDbType.VarChar, 30).Value = companyEmail;
                s.Parameters.Add("@title", SqlDbType.VarChar, 30).Value = title;
                s.Parameters.Add("@salesPerPurchCode", SqlDbType.VarChar, 30).Value = salesPerPurchCode;
                s.Parameters.Add("@noSeries", SqlDbType.VarChar, 30).Value = noSeries;
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
            string sqlQuery = "update [CRONUS Sverige AB$Employee] SET [First_Name] = @firstName where Employee_No_ = @id";

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

