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
       private static Jewelry myCart = new Jewelry();

        // Create AddToCart method, with input type Jewelry. 

        public void AddToCart(Jewelry nameofjewelry)
            {
            // Take input jewely count and add to myCart
            
            myCart.Necklaces += nameofjewelry.Necklaces;
            myCart.Pendents += nameofjewelry.Pendents;
            myCart.Earrings += nameofjewelry.Earrings;
            myCart.Longchains += nameofjewelry.Longchains;
            }


        }
        #endregion
}
