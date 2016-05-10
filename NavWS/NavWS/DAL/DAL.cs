using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NavWS.DAL
{
    public class DAL
    {
        SqlConnection con = new SqlConnection();
        public DAL()
        {
            con.ConnectionString =
   "user id=grupp15;" +
     "password=Grupp15;server=klippan.privatedns.org;" +
   "Trusted_Connection=yes;" +
   "database=Demo Database NAV (5-0); " +
   "connection timeout=30";
        }

        // String con = @"Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15";
        //  SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Company", con);
    }
}
