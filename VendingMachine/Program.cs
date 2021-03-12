using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Choose Product");
            Console.WriteLine("Cola");
            Console.WriteLine("Chips");
            Console.WriteLine("Candy");
            Console.WriteLine("");
            String product = "";
            product = Console.ReadLine().ToString();

            if (!((product.ToUpper() == Constants.cola) || (product.ToUpper() == Constants.chips) || (product.ToUpper() == Constants.candy)))
            {
                Console.WriteLine("Product is not available, Please choose from above list");
                Console.ReadLine();
            }

            else
            {


                String coinType = "";
                double amount = 0;
                String coinReturn = "";
                Products objPrd = new Products();
                while (true)
                {
                    Console.WriteLine("Please Insert Coin");

                    Console.WriteLine("Coin Weight is ");
                    int weight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Coin Size is ");
                    int size = Convert.ToInt32(Console.ReadLine());

                    Denominations objDnm = new Denominations();

                    coinType = objDnm.InsertedCoinIs(weight, size);

                    double coinValue = 0;

                    switch (coinType)
                    {
                        case Constants.nickel: coinValue = Constants.nickelValue; break;

                        case Constants.dime: coinValue = Constants.dimeValue; break;

                        case Constants.quarter: coinValue = Constants.quarterValue; break;

                        case Constants.penny: coinValue = Constants.pennyValue; break;

                        default: coinValue = 0; break;

                    }

                    if (coinValue == 0)
                    {
                        Console.WriteLine("Please insert valid coin");
                        break;
                    }
                    else if (coinValue == 0.01)
                    {
                        coinReturn = coinReturn + coinType;
                        Console.WriteLine("Pennies are not allowed. Please insert valid coin");
                        break;
                    }
                    else
                    {
                        amount = (amount + coinValue);
                    }

                    if (objPrd.getProduct(product, amount))
                    {
                        break;
                    }

                }

                Console.ReadLine();
            }
        }
    }
}
