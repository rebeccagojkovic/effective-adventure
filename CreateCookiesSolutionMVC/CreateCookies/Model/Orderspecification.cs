using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Orderspecification
    {
        private int palletQuantity;
        private Order order;
        private Product product;

        public Orderspecification(int palletQuantity, Order order, Product product)
        {

        }

        public int PalletQuantity
        {
            get
            {
                return palletQuantity;
            }

            set
            {
                palletQuantity = value;
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
