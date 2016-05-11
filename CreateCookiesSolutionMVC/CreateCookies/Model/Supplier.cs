using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Supplier
    {
        private string sNumber;
        private string sLocation;
        private List<Ingredient> ingredient;

        public Supplier(string sNumber, string sLocation, List<Ingredient> ingredient)
        {

        }
        public string SNumber
        {
            get
            {
                return sNumber;
            }

            set
            {
                sNumber = value;
            }
        }

        public string SLocation
        {
            get
            {
                return sLocation;
            }

            set
            {
                sLocation = value;
            }
        }

        internal List<Ingredient> Ingredient
        {
            get
            {
                return ingredient;
            }

            set
            {
                ingredient = value;
            }
        }
    }
}
