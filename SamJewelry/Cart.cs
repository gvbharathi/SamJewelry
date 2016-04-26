using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
    class Cart
    {
        public List<Jewelry> JewelryCart = new List<Jewelry>();


        public void AddToCart(Jewelry item)

        {
            JewelryCart.Add(item);

        }

        public void ViewCart()
        {
            Console.WriteLine("Name of Jewelry   Meterial   Quantity     Cost");


            foreach (Jewelry item in JewelryCart)
            {
                Console.WriteLine(item.NameofJewelry +
                    "                " + item.NameofMeterial +
                    "     " + item.QuantityofJewelry +
                    "     " + item.CostofJewelry);

            }


        }

    }
}
