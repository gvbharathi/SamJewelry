using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
    class Cart
    {
        #region Method
     
        // create an instance of Jewely
       public Jewelry myCart = new Jewelry();

        // Create AddToCart method, with input type Jewelry. 
        public void AddToCart(Jewelry nameofjewelry)
            {
            // Take input jewely count and add to myCart

            myCart.Necklaces += nameofjewelry.Necklaces;

            }


        }
        #endregion
}
