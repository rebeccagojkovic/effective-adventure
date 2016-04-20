using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Customer
    {
        private string cNumber;
        private string cName;
        private string cAddress;
        private List<Order> order;

        public Customer(string cNumber, string cName, string cAddress)
        {
            this.cNumber = cNumber;
            this.cName = cName;
            this.cAddress = cAddress;
        }
        public Customer()
        {

        }
        public string CNumber
        {
            get
            {
                return cNumber;
            }

            set
            {
                cNumber = value;
            }
        }

        public string CName
        {
            get
            {
                return cName;
            }

            set
            {
                cName = value;
            }
        }

        public string CAddress
        {
            get
            {
                return cAddress;
            }

            set
            {
                cAddress = value;
            }
        }
        internal List<Order> Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
            }
        }
    }
}

    
