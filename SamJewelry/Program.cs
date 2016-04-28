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
            Cart myCart = new Cart();


            Jewelry myJewelry;
            int myJewelryQuantity = 1;
            JewelryName myJewelryName = JewelryName.Necklace;
            MeterialName myJewelryMeterial = MeterialName.Gold;
            var option = "1";
            Console.WriteLine("*************Welcome To SamJewelry**********");

            Console.WriteLine("Enter Customer Name:");
            string myCustomerName=Console.ReadLine();
            Console.WriteLine("Enter Address:");
            string myAddress = Console.ReadLine();
            Console.WriteLine("{0},{1}", myCustomerName,myAddress);
            Customer myCustomer = new Customer()
            {
                CustomerName = myCustomerName,
                Address = myAddress,

            };
         do
            {
               

                Console.WriteLine("\n\nPlease Select one of the options below");

                Console.WriteLine("1 - Create new Jewely");
                Console.WriteLine("2 - Add Jewelry to the cart");
                Console.WriteLine("3 - Remove Jewerly from the cart");
                Console.WriteLine("4 - View Cart");
                Console.WriteLine("5 - Exit");

                // Read user Option input into varilabe caled Option of type var
                option = Console.ReadLine();


                switch (option)
                {
                    #region Create Jewelry
                    case "1":
                        Console.WriteLine("\nSelection the Jewerly Name");
                        Console.WriteLine("1 - Neckles");
                        Console.WriteLine("2 - Bangles");
                        Console.WriteLine("3 - EarRings");

                        var JewelryNameOption = Console.ReadLine();


              switch (JewelryNameOption)
                        {
                  case "2":
                    myJewelryName = JewelryName.Bangles;
                                break;
                       case "3":
                                myJewelryName = JewelryName.Earrings;
                           break;
                        }

                        Console.WriteLine("\nSelect Material Type");
                        Console.WriteLine("1- Gold");
                        Console.WriteLine("2 - Silver");

                        var JewerlyMaterialOption = Console.ReadLine();

                        switch (JewerlyMaterialOption)
                        {
                            case "2":
                                myJewelryMeterial = MeterialName.silver;
                                break;

                        }

                        Console.WriteLine("\nEnter Quantity");
                        myJewelryQuantity = int.Parse(Console.ReadLine());

                        // develop program to compute the cost of Jewelry based on the price, name, material and qunaity
                        break;

                    #endregion

                    // Add to Cart

                    case "2":

                        myJewelry = new Jewelry()
                        {
                            NameofJewelry = myJewelryName,
                            NameofMeterial = myJewelryMeterial,
                            QuantityofJewelry = myJewelryQuantity,
                            CostofJewelry = 2000.00,
                        };
                        myCart.AddToCart(myJewelry);

                        Console.WriteLine("\nYour Jewelry is added to the cart successfully");

                        break;

                    //View Cart

                    case "4":
                        myCart.ViewCart();
                        break;

                }
            } while (option != "5");
        }
    }
}
