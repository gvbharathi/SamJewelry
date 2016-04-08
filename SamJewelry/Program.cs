using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
  
    class Program
    {
       

        static void Main(string[] args)
        {
            
          //create an instance of Jewelry 
            var Jewelry1 = new Jewelry();
          Jewelry1.JeWelryName = "goldJewelry";
            Jewelry1.Typeofjewelry = Jewelrytype.GoldJewelry;

            // Addtocart

            Jewelry1.AddNecklacestocart(2);




            // View cart 
            Jewelry1.viewcart();




        }
    }
}
