using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CreateCookies.View;

namespace CreateCookies.Controller
{
    public class Controller
    {
        CreateCookiesDataSetTableAdapters.CustomerTableAdapter CDAL = new CreateCookiesDataSetTableAdapters.CustomerTableAdapter();

        public Controller()
        {

        }
        public void RegisterCustomer(string cNumber, string cAddress, string cCountry, string cEmail, string cName, string cPostalAddress)
        {
            CDAL.RegisterCustomerQuery(cNumber, cAddress, cCountry, cEmail, cName, cPostalAddress);
        }
    }
}
