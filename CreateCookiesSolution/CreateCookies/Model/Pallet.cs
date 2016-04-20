using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Pallet
    {
        private string palletNumber;
        private DateTime palletTime;
        private string pNumber;
        private string oNumber;
        private Order order;
        private Product product;

        public Pallet(string palletNumber, DateTime palletTime, string pNumber, string oNumber, Order order, Product product)
        {

        }

        public string PalletNumber
        {
            get
            {
                return palletNumber;
            }

            set
            {
                palletNumber = value;
            }
        }

        public DateTime PalletTime
        {
            get
            {
                return palletTime;
            }

            set
            {
                palletTime = value;
            }
        }

        public string PNumber
        {
            get
            {
                return pNumber;
            }

            set
            {
                pNumber = value;
            }
        }

        public string ONumber
        {
            get
            {
                return oNumber;
            }

            set
            {
                oNumber = value;
            }
        }

        internal Order Order
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

        internal Product Product
        {
            get
            {
                return product;
            }

            set
            {
                product = value;
            }
        }
    }
}
