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
        private string cPostalAddress;
        private string cCountry;
        private string cEmail;
        private List<Order> order;

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

        public string CPostalAddress
        {
            get
            {
                return cPostalAddress;
            }

            set
            {
                cPostalAddress = value;
            }
        }

        public string CCountry
        {
            get
            {
                return cCountry;
            }

            set
            {
                cCountry = value;
            }
        }

        public string CEmail
        {
            get
            {
                return cEmail;
            }

            set
            {
                cEmail = value;
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

    
