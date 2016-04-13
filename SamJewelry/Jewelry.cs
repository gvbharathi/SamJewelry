using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry

{
    public enum Jewelrytype
    {
        GoldJewelry,
        silverJewelry,

    }

    /// <summary>
    /// This is about Jewelry Collection
    /// </summary>
    public class Jewelry
    {
        #region  properties
        /// <summary>
        /// Name of the Jewelry
        /// </summary>

        public int NumberofNeckleces { get; set; }
        /// <summary>
        /// Name of the Jewelry
        /// </summary>
        public string JeWelryName { get; set; }
        public Jewelrytype Typeofjewelry { get; internal set; }
        //public JewelryType TypeofJewelry { get; set; }
        #endregion
        #region methods
        public void AddToCart(int necklacescount)
        {
            NumberofNeckleces += necklacescount;
        }
        
            #endregion

         public void viewcart()
        {
            Console.WriteLine("No of Necklaces:  " + NumberofNeckleces);
             
        }
    }

  }

   