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

        public List<Models.Employee> GetAllEmployeesList()
        {
            con.Open();
            try
            {
                List<Models.Employee> list = new List<Models.Employee>();

                String query = "SELECT * FROM [Demo Database NAV (5-0)].[dbo].[CRONUS Sverige AB$Employee]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    var result = new Models.Employee();
                    byte[] b = null;
                    reader.GetBytes(0, 0, b, 0, 1024);
                    result.Employee_No_ = reader.GetString(1);
                    result.First_Name = reader.GetString(2);
                    result.Middle_Name = reader.GetString(3);
                    result.Last_Name = reader.GetString(4);
                    result.Initials = reader.GetString(5);
                    result.Job_Title = reader.GetString(6);
                    result.Search_Name = reader.GetString(7);
                    result.Address = reader.GetString(8);
                    result.Address_2 = reader.GetString(9);
                    result.City = reader.GetString(10);
                    result.Post_Code = reader.GetString(11);
                    result.County = reader.GetString(12);
                    result.Phone_No_ = reader.GetString(13);
                    result.Mobile_PhoneNo_ = reader.GetString(14);
                    result.E_Mail = reader.GetString(15);
                    result.Alt__Address_Code = reader.GetString(16);
                    result.Alt__Address_Start_Date = reader.GetDateTime(17);
                    result.Alt__Address_End_Date = reader.GetDateTime(18);
                    result.Birth_Date = reader.GetDateTime(20);
                    result.Social_Security_No_ = reader.GetString(21);
                    result.Union_Code = reader.GetString(22);
                    result.Union_Membership_No_ = reader.GetString(23);
                    result.Sex = reader.GetInt32(24);
                    result.Country_Region_Code = reader.GetString(25);
                    result.Manager_No_ = reader.GetString(26);
                    result.Emplymt__Contract_Code = reader.GetString(27);
                    result.Statistics_Group_Code = reader.GetString(28);
                    result.Employment_Date = reader.GetDateTime(29);
                    result.Status = reader.GetInt32(30);
                    result.Inactive_Date = reader.GetDateTime(31);
                    result.Cause_of_Inactivity_Code = reader.GetString(32);
                    result.Termination_Date = reader.GetDateTime(33);
                    result.Grounds_for_Term__Code = reader.GetString(34);
                    result.Global_Dimension_1_Code = reader.GetString(35);
                    result.Global_Dimension_2_Code = reader.GetString(36);
                    result.Resource_No_ = reader.GetString(37);
                    result.Last_Date_Modified = reader.GetDateTime(38);
                    result.Extension = reader.GetString(39);
                    result.Pager = reader.GetString(40);
                    result.Fax_No_ = reader.GetString(41);
                    result.Company_E_Mail = reader.GetString(42);
                    result.Title = reader.GetString(43);
                    result.Salespers__Purch__Code = reader.GetString(44);
                    result.No__Series = reader.GetString(45);

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
       
        public List<Models.EmployeeMeta> GetEmployeesMeta2()
        {
            con.Open();
            try
            {
                List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                String query = "SELECT b.name, a.name FROM sys.columns a JOIN sys.tables b ON a.object_id = b.object_id WHERE b.name LIKE 'CRONUS Sverige AB$Employee'";
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
        
        public List<Models.EmployeeRelative> GetRelative()
        {
            con.Open();
            try
            {
                List<Models.EmployeeRelative> list = new List<Models.EmployeeRelative>();

                String query = "select a.[Employee No_],a.[Relative Code],a.[First Name],b.[First_Name]"
                + " from [CRONUS Sverige AB$Employee Relative] a inner join [CRONUS Sverige AB$Employee]"
                + " b on a.[Employee No_]=b.[Employee_No_]";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeRelative();
                    result.Employee_No_ = reader.GetString(0);
                    result.Relative_Code = reader.GetString(1);

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
        
        public List<Models.EmployeeAbsence> GetEmployeeAbsence()
        {
            con.Open();
            try
            {
                List<Models.EmployeeAbsence> list = new List<Models.EmployeeAbsence>();

                String query = "select a.[Employee No_], a.Description from [CRONUS Sverige AB$Employee Absence]"
                + " a where a.[From Date] < CONVERT(DateTime, '2004-12-31 12:00:00.000') and"
                + " a.[From Date] > CONVERT(DateTime, '2004-01-01 00:00:00.000') and"
                + " a.[Cause of Absence Code] = 'SJUK'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeAbsence();
                    result.Employee_No_ = reader.GetString(0);
                    result.Cause_of_Absence_Code = reader.GetString(1);

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
        
        public List<Models.Employee> GetSickestEmployee()
        {
            con.Open();
            try
            {
                List<Models.Employee> list = new List<Models.Employee>();

                String query = "select top 1 a.[First_Name] from [CRONUS Sverige AB$Employee] a inner join"
                + " [CRONUS Sverige AB$Employee Absence] b on a.Employee_No_ = b.[Employee No_] and b.[Cause of Absence Code]"
                + " = 'SJUK' group by a.[First_Name] order by count(*) desc";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.Employee();
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
        
        //---------------------- Add/Delete/Insert/Update SQL ----------------------

        public List<Models.Employee> GetEmployee(string id)
        {

            con.Open();
            try
            {
                List<Models.Employee> list = new List<Models.Employee>();

                String query = "select * from"
                    + " [CRONUS Sverige AB$Employee] a where a.Employee_No_ = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    var result = new Models.Employee();
                    byte[] b = null;
                    reader.GetBytes(0, 0, b, 0, 1024);
                    result.Employee_No_ = reader.GetString(1);
                    result.First_Name = reader.GetString(2);
                    result.Middle_Name = reader.GetString(3);
                    result.Last_Name = reader.GetString(4);
                    result.Initials = reader.GetString(5);
                    result.Job_Title = reader.GetString(6);
                    result.Search_Name = reader.GetString(7);
                    result.Address = reader.GetString(8);
                    result.Address_2 = reader.GetString(9);
                    result.City = reader.GetString(10);
                    result.Post_Code = reader.GetString(11);
                    result.County = reader.GetString(12);
                    result.Phone_No_ = reader.GetString(13);
                    result.Mobile_PhoneNo_ = reader.GetString(14);
                    result.E_Mail = reader.GetString(15);
                    result.Alt__Address_Code = reader.GetString(16);
                    result.Alt__Address_Start_Date = reader.GetDateTime(17);
                    result.Alt__Address_End_Date = reader.GetDateTime(18);
                    result.Birth_Date = reader.GetDateTime(20);
                    result.Social_Security_No_ = reader.GetString(21);
                    result.Union_Code = reader.GetString(22);
                    result.Union_Membership_No_ = reader.GetString(23);
                    result.Sex = reader.GetInt32(24);
                    result.Country_Region_Code = reader.GetString(25);
                    result.Manager_No_ = reader.GetString(26);
                    result.Emplymt__Contract_Code = reader.GetString(27);
                    result.Statistics_Group_Code = reader.GetString(28);
                    result.Employment_Date = reader.GetDateTime(29);
                    result.Status = reader.GetInt32(30);
                    result.Inactive_Date = reader.GetDateTime(31);
                    result.Cause_of_Inactivity_Code = reader.GetString(32);
                    result.Termination_Date = reader.GetDateTime(33);
                    result.Grounds_for_Term__Code = reader.GetString(34);
                    result.Global_Dimension_1_Code = reader.GetString(35);
                    result.Global_Dimension_2_Code = reader.GetString(36);
                    result.Resource_No_ = reader.GetString(37);
                    result.Last_Date_Modified = reader.GetDateTime(38);
                    result.Extension = reader.GetString(39);
                    result.Pager = reader.GetString(40);
                    result.Fax_No_ = reader.GetString(41);
                    result.Company_E_Mail = reader.GetString(42);
                    result.Title = reader.GetString(43);
                    result.Salespers__Purch__Code = reader.GetString(44);
                    result.No__Series = reader.GetString(45);

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

        public void AddEmployeeMini(string id, string firstName, string lastName)
        {

            Connect();
            string sqlQuery = "INSERT INTO [dbo].[CRONUS Sverige AB$Employee]([Employee_No_],[First_Name],[Last_Name])"
                + "VALUES (@id, @firstName, @lastName)";

            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);

            s.Parameters.Add("@id", SqlDbType.VarChar, 30).Value = id;
            s.Parameters.Add("@firstName", SqlDbType.VarChar, 40).Value = firstName;
           
            s.Parameters.Add("@lastName", SqlDbType.VarChar, 30).Value = lastName;
            try
            {

                s.ExecuteNonQuery();
            }
            catch (SqlException)
            {
            }
        }




        public void AddEmployee(string id, string firstName, string middleName, string lastName, string initials, string jobTitle, string searchName, string adress, string adress2, string city, string postCode, string county, string phoneNumber, string mobilePhoneNumber, string eMail, string altAdress, DateTime altAdressStart, DateTime altAdressEnd, string picture, DateTime birthDate, string socialSecurityNumber, string unionCode, string unionMembershipNumber, int sex, string countryRegionCode, string managerNumber, string employmentContractCode, string statisticsGroupCode, DateTime employmentDate, int status, DateTime inactivityDate, string causeOfInactivity, DateTime terminationDate, string groundsForTermCode, string globalDimension1Code, string globalDimension2Code, string resourceNumber, DateTime lastDateModified, string extension, string pager, string faxNumber, string companyEmail, string title, string salesPerPurchCode, string noSeries)
        {
            Connect();
            string sqlQuery = "INSERT INTO [dbo].[CRONUS Sverige AB$Employee]([Employee_No_],[First_Name],[Middle_Name],[Last_Name],[Initials],[Job_Title],[Search_Name],[Address],[Address 2],[City],[Post_Code],[County],[Phone_No_],[Mobile_PhoneNo_],[E-Mail],[Alt_ Address Code],[Alt_ Address Start Date],[Alt_ Address End Date],[Picture],[Birth_Date],[Social_Security No_],[Union_Code],[Union_Membership No_],[Sex],[Country_Region Code],[Manager_No_],[Emplymt_ Contract Code],[Statistics_Group_Code],[Employment_Date],[Status],[Inactive_Date],[Cause_of_Inactivity Code],[Termination_Date],[Grounds for Term_ Code],[Global Dimension 1 Code],[Global Dimension 2 Code],[Resource No_],[Last Date Modified],[Extension],[Pager],[Fax No_],[Company E-Mail],[Title],[Salespers__Purch_ Code],[No_ Series]) "
                     + "VALUES (@id, @firstName, @middleName, @lastName, @initials, @jobTitle, @searchName, @adress, @adress2, @city, @postCode, @county, @phoneNumber, @mobilePhoneNumber, @eMail, @altAdressCode, @altAdressStart, @altAdressEnd, @picture, @birthDate, @socialSecurityNumber, @unionCode, @unionMembershipNumber, @sex, @countryRegionCode, @managerNumber, @employmentContractCode, @statisticsGroupCode, @employmentDate, @status, @inactivityDate, @causeOfInactivity, @terminationDate, @groundsForTermCode, @globalDimension1Code, @globalDimension2Code, @resourceNumber, @lastDateModified, @extension, @pager, @faxNumber, @companyEmail, @title, @salesPerPurchCode, @noSeries) ";


            SqlCommand s = new SqlCommand(sqlQuery, sqlConnection);
           // s.Parameters.Add("@timestamp", SqlDbType.Bit, 30).Value = timestamp;
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
            }
        }



        public void DeleteEmployee(string id)
        {
            Connect();
            string sqlQuery = "delete from [CRONUS Sverige AB$Employee] where Employee_No_ = @id";

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
        public List<Models.EmployeeMeta> GetKeys()
        {
            con.Open();
            try
            {
                List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                String query = "select top 100 CONSTRAINT_NAME from INFORMATION_SCHEMA.KEY_COLUMN_USAGE";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeMeta();
                    result.Table_Name = reader.GetString(0);

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
        
        public List<Models.EmployeeMeta> GetIndexes()
        {
            con.Open();
            try
            {
                List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                String query = "select top 100 a.object_id, a.name from sys.indexes a where a.name like 'CRONUS%'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var result = new Models.EmployeeMeta();
                    result.Object_ID = reader.GetInt32(0);
                    result.Table_Name = reader.GetString(1);

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
        
        public List<Models.EmployeeMeta> GetConstraints()
        {
            {
                con.Open();
                try
                {
                    List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                    String query = "select top 100 CONSTRAINT_NAME, TABLE_NAME from INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var result = new Models.EmployeeMeta();
                        result.Constraint_Name = reader.GetString(0);
                        result.Table_Name = reader.GetString(1);

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
        }
       
        public List<Models.EmployeeMeta> GetAllTables()
        {
            {
                con.Open();
                try
                {
                    List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                    String query = "select top 100 a.TABLE_NAME from INFORMATION_SCHEMA.TABLES a";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var result = new Models.EmployeeMeta();
                        result.Table_Name = reader.GetString(0);

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
        }
        
        public List<Models.EmployeeMeta> GetAllTables2()
        {
            {
                con.Open();
                try
                {
                    List<Models.EmployeeMeta> list = new List<Models.EmployeeMeta>();

                    String query = "select top 100 a.name from sys.tables a;";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        var result = new Models.EmployeeMeta();
                        result.Table_Name = reader.GetString(0);

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
        }
        
    }
}

