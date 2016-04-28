using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Product
    {
        private string pNumber;
        private string pName;
        private DateTime pTime;
        private double price;
        private List<Recipe> recipe;
        private List<Orderspecification> orderspecification;
        private List<Pallet> pallet;

        public Product(string pNumber, string pName, DateTime pTime, double price, List<Recipe> recipe, List<Orderspecification> orderspecification, List<Pallet> pallet)
        {

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

        public string PName
        {
            get
            {
                return pName;
            }

            set
            {
                pName = value;
            }
        }

        public DateTime PTime
        {
            get
            {
                return pTime;
            }

            set
            {
                pTime = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
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

        internal List<Recipe> Recipe
        {
            get
            {
                return recipe;
            }

            set
            {
                recipe = value;
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
    }
}