using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
   static class Store
    {
        ///<summary>
        /// Create a new Jewelry for the user
        /// <param name="NameofMeterial">Name of Meterial</param>
        /// <param name="NameofJewelry"> name of your Jewelry</param>
        /// <param name="CostofJewelry"> Cost of Jewelry</param>
        /// <param name="QuantityofJewelry"> Quantity of Jewelry</param>
        /// <return> New Jewelry</return>
        /// </summary>
        public static Jewelry CreateJewelry(MeterialName NameofMeterial, JewelryName NameofJewelry, double CostofJewelry, int QuantityofJewelry)
        {
            var MyJewelry = new Jewelry
            {
                NameofMeterial = NameofMeterial,
                NameofJewelry = NameofJewelry,
                CostofJewelry = CostofJewelry,
                QuantityofJewelry = QuantityofJewelry

            };
            return MyJewelry;

        }
    }
}

