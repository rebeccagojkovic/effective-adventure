using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateCookies.Model
{
    class Recipe
    {
        private double quantity;
        private Ingredient ingredient;
        private Product product;

       

        public double Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }

        internal Ingredient Ingredient
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
