using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{ 
            public class Store
    {

       static Cart myCart = new Cart();
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

