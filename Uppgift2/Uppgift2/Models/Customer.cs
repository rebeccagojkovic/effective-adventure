using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Uppgift2.Models
{
    public class Customer
    {
        public string CNumber { get; set; }
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string CPostalAddress { get; set; }
        public string CCountry { get; set; }
        public string CEmail { get; set; }

        public Customer()
        {
        }

        public Customer(string cNumber, string cName, string cAddress, string cPostalAddress, string cCountry, string cEmail)
        {
            this.CNumber = cNumber;
            this.CName = cName;
            this.CAddress = cAddress;
            this.CPostalAddress = cPostalAddress;
            this.CCountry = cCountry;
            this.CEmail = cEmail;
        }
    }
}