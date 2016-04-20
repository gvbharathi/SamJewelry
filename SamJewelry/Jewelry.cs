using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry

{
    public enum MeterialName
    {
        Gold,
        silver,

    }

    public enum JewelryName
    {
        Necklace,
        Earrings,
        Bangles,
    }



    /// <summary>
    /// This is about Jewelry Collection
    /// </summary>
    public class Jewelry
    {
        #region  properties
        /// <summary>
        /// Meterial type
        /// </summary>
        public MeterialName NameofMeterial{ get; set; }
        /// <summary>
        /// Name of the Jewelry
        /// </summary>
        public JewelryName NameofJewelry { get; set; }
        /// <summary>
        ///  Cost of the Jewelry
        /// </summary>
        public  Double CostofJewelry { get;  set; }
        /// <summary>
        /// Jewelry Quantity
        /// </summary>
        public int QuantityofJewelry { get; set; }
        /// <param name="necklacescount"></param>
        
        #endregion
      
    }

}

   