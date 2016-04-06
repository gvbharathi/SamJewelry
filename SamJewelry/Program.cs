using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamJewelry
{
  
    class Program
    {
        private  string JewelryName;

        static void Main(string[] args)
        {
            //create an instnace of Cart

            Cart cart1 = new Cart();

           
          //create an instance of Jewelry 
            var Jewelry1 = new Jewelry();
          Jewelry1.JeWelryName = "goldJewelry";
            Jewelry1.Typeofjewelry = Jewelrytype.GoldJewelry;

            var Jewelry2 = new Jewelry();
            Jewelry1.JeWelryName = "silver";
            Jewelry2.Typeofjewelry = Jewelrytype.silverJewelry;
       
            
            cart1.AddToCart(Jewelry1);
       // Pick jewelry items and put it cart


            // View cart 




        }
    }
}
