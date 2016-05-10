using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NavWS.DAL
{
    public class DAL
    {
        String con = @"Data Source=klippan.privatedns.org;Initial Catalog=Demo Database NAV (5-0);Persist Security Info=True;User ID=grupp15;Password=Grupp15";
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Company", con);
    }
}