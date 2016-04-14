using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
    public static class Store
    {
        ///<summary>
        /// Create a new Jewelry for the user
        /// </summary>
        /// <param name="jewelryName">Name of Jewelry</param>
        /// <param name="numberofJewelry"> number of your Jewelry</param>
        /// <param name="typeofJewelry">The type of Jewelry</param>
        /// <return> New Jewelry</return>
        public static Jewelry CreateJewelry(string JewelryName, int numberofJewelry, Jewelrytype typeofJewelry)

        {
            var Myjewelry = new Jewelry
            {
                JewelryName = JewelryName,
                NumberofNeckleces = numberofJewelry,
                TypeofJewelry = typeofJewelry


            };
            return Myjewelry;
        }
        
        }
}
