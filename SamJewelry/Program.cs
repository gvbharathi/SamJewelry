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
            Console.WriteLine("***********Welcome to SamJewelry***********");
            Console.WriteLine("1. Create a Jewelry ");
            Console.WriteLine("2. Add To Cart");
            Console.WriteLine("3. View Cart");
            Console.WriteLine("0. Exit");

            var option = Console.ReadLine();
            switch(option)

            {
                case "1":

                    Console.WriteLine("What is the name of the Jewelry");
                    var jewelryName = Console.ReadLine();
                    var MyJewelry = Store.CreateJewelry(jewelryName, 2, Jewelrytype.GoldJewelry);

                    Console.WriteLine("Jewelry Name:{0},Number of Jewelry{1}, Type of Jewelry:{2}",
                               MyJewelry.JewelryName, MyJewelry.NumberofNeckleces, MyJewelry.TypeofJewelry);
                    break;
                case "2":
                    break;
                case "0":

                    Console.WriteLine("Good bye");
                    return;

                default:
                    break;

              
            }

}
    }
}
