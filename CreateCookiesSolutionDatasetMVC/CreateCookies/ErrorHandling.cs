using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies
{
    class ErrorHandling
    {
        public string SQLError(SqlException ex)
        {
            return ("You have got an SQL error: " + ex.Message);
        }
        public string HandleException(Exception ex)
        {
            if (ex is SqlException)
            {
                SqlException sqlError= ex as SqlException;
                return SQLError(sqlError);
            }
            else
            {
                return "You have to fill in all fealds";
            }
        }
    }
}
