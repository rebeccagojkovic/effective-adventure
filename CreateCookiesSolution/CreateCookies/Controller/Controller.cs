using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
