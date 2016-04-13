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
            var MyJewelry = new Jewelry();
         MyJewelry.JeWelryName = "goldJewelry";
           MyJewelry.Typeofjewelry = Jewelrytype.GoldJewelry;

            // Addtocart

            MyJewelry.AddNecklacestocart(2);
           
           // View cart 
            MyJewelry.viewcart();

            Console.ReadLine();




        }
    }
}
