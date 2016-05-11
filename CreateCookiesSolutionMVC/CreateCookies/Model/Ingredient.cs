using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Ingredient
    {
        private string iNumber;
        private string iName;
        private double iQuantityInStock;
        private List<Recipe> recipe;
        private Supplier supplier;

        public Ingredient(string iNumber, string iName, double iQuantityInStock, List<Recipe> recipe, Supplier supplier)
        {
            this.iNumber = iNumber;
            this.iName = iName;
            this.iQuantityInStock = iQuantityInStock;
            this.recipe = recipe;
            this.supplier = supplier;

        }

        public string INumber
        {
            get
            {
                return iNumber;
            }

            set
            {
                iNumber = value;
            }
        }

        public string IName
        {
            get
            {
                return iName;
            }

            set
            {
                iName = value;
            }
        }

        public double IQuantityInStock
        {
            get
            {
                return iQuantityInStock;
            }

            set
            {
                iQuantityInStock = value;
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

        internal Supplier Supplier
        {
            get
            {
                return supplier;
            }

            set
            {
                supplier = value;
            }
        }
    }
}
