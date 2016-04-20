using CreateCookies.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateCookies.Controller
{
    public class Controller
    {
        CreateCookiesDataSetTableAdapters.CustomerTableAdapter CDAL = new CreateCookiesDataSetTableAdapters.CustomerTableAdapter();

        public Controller()
        {

        }
        //public void RegisterCustomer(string cNumber, string cAddress, string cCountry, string cEmail, string cName, string cPostalAddress)
        //{
        //    CDAL.RegisterCustomerQuery(cNumber, cAddress, cCountry, cEmail, cName, cPostalAddress);
        //}
        public void Customer(string cNumber, string cName, string cAddress)
        {

        }
        public void Ingredient(string iNumber, string iName, double iQuantityInStock)
        {
            
        }
        public void Order(string oNumber, bool isDelivered, DateTime expectedDeliveryDate)
        {
            
        }

        public void Orderspecification(int palletQuantity)
        {

        }
        public void Pallet(string palletNumber, DateTime palletTime, string pNumber, string oNumber)
        {

        }
        public void Product(string pNumber, string pName, DateTime pTime, double price)
        {


        }
        public void Recipe(double quantity)
        {

        }

        public void Supplier(string sNumber, string sLocation)
        {

        }
        

    }
}
