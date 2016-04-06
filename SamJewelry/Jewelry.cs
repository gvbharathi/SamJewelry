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
        public int Necklaces { get;  set; }
        /// <summary>
        /// Name of the Jewelry
        /// </summary>
        public int Earrings { get; set; }

        public int Pendents { get; set; }

        public int Bangles { get; set; }

        public int Longchains { get; set; }
        public string JeWelryName { get; set; }
        public Jewelrytype Typeofjewelry { get; internal set; }
        //public JewelryType TypeofJewelry { get; set; }

        #endregion


    }

   }