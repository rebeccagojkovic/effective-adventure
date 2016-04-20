using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Order
    {
        private string oNumber;
        private bool isDelivered;
        private DateTime expectedDeliveryDate;
        private Customer customer;
        private List<Orderspecification> orderspecification;
        private List<Pallet> pallet;

        public Order(string oNumber, bool isDelivered, DateTime expectedDeliveryDate, Customer customer, List<Orderspecification> orderspecification, List<Pallet> pallet)
        {

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

        public bool IsDelivered
        {
            get
            {
                return isDelivered;
            }

            set
            {
                isDelivered = value;
            }
        }

        public DateTime ExpectedDeliveryDate
        {
            get
            {
                return expectedDeliveryDate;
            }

            set
            {
                expectedDeliveryDate = value;
            }
        }

        internal Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        internal List<Orderspecification> Orderspecification
        {
            get
            {
                return orderspecification;
            }

            set
            {
                orderspecification = value;
            }
        }

        internal List<Pallet> Pallet
        {
            get
            {
                return pallet;
            }

            set
            {
                pallet = value;
            }
        }
    }
}
