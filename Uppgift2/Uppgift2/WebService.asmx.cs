using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Uppgift2
{
    /// <summary>
    /// Summary description for WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<Models.Customer> GetCustomersList()
        {
            Controllers.Controller cont = new Controllers.Controller();
            return cont.GetCustomersList();
        }
        [WebMethod]
        public List<string> GetCustomers()
        {
            Controllers.Controller cont = new Controllers.Controller();
            return cont.GetCustomers();
        }

    }
}


