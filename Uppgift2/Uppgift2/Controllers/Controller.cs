using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift2.Controllers
{
    public class Controller
    {
        private DAL.DAL dal = new DAL.DAL();

        public Controller()
        {

        }
        public List<Models.Customer> GetCustomersList()
        {
            return dal.GetCustomerList();
        }
        public List<string> GetCustomers()
        {
            return dal.GetCustomers();
        }
    }
}