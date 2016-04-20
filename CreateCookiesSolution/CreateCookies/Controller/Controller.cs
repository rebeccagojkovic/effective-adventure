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
        public void Ingredient(string iNumber, string iName, double iQuantityInStock, List<Recipe> recipe, Supplier supplier)
        {
            
        }
        public void Order(string oNumber, bool isDelivered, DateTime expectedDeliveryDate, Customer customer, List<orderspecification> orderspecification, List<Pallet> pallet, string oNumber)
        {
            
        }

        public void Orderspecification(int palletQuantity, Order order, Product product, int PalletQuantity)
        {

        }
        public void Pallet(string palletNumber, DateTime palletTime, string pNumber, string oNumber, Order order, Product product, string PalletNumber)
        {

        }
        public void Product(string pNumber, string pName, DateTime pTime, double price, List<Recipe> recipe, List<orderspecification> orderspecification, List<Pallet> pallet)
        {


        }
        public void Recipe(double quantity, Ingredient ingredient, Product product)
        {

        }

        public void Supplier(string sNumber, string sLocation, List<Ingredient> ingredient)
        {

        }
        private string sNumber;
        private string sLocation;
        private List<Ingredient> ingredient;

    }
}
