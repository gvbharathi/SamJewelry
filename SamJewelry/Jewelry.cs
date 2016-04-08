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
        #region methods
        public void AddNecklacestocart(int numberofnecklaces)
        {
            Necklaces += numberofnecklaces;
        }

        public void AddEarringstocart(int numberofearrings)
        {
            Earrings += numberofearrings;
        }

        public void AddPendentstocart(int numberofpendents)
        {
            Pendents += numberofpendents;
        }
        public void AddBanglestocart(int numberofBangles)
        {
            Bangles += numberofBangles;
        }
        public void AddLongchainstocart(int numberofLongchains)
        {
            Longchains +=numberofLongchains;
        }
            #endregion

         public void viewcart()
        {
            Console.WriteLine("No of Necklaces:  " + Necklaces);
            Console.WriteLine("No of Earings:  " + Earrings);
            Console.WriteLine("No of Pendents:  " + Pendents);
            Console.WriteLine("No of Bangles:  " + Bangles);
            Console.WriteLine("No of Longchains:  " + Longchains); 
        }
    }

  }

   