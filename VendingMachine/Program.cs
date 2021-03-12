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
                String amount = "0";
                String coinReturn = "";
                Products pd = new Products();
                while (true)
                {
                    Console.WriteLine("Please Insert Coin");

                    Console.WriteLine("Coin Weight is ");
                    int weight = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Coin Size is ");
                    int size = Convert.ToInt32(Console.ReadLine());

                    Money objMoney = new Money();

                    coinType = objMoney.InsertedCoinIs(weight.ToString(), size.ToString());

                    String coinValue = "";

                    switch (coinType)
                    {
                        case Constants.nickel: coinValue = Constants.nickelValue.ToString(); break;

                        case Constants.dime: coinValue = Constants.dimeValue.ToString(); break;

                        case Constants.quarter: coinValue = Constants.quarterValue.ToString(); break;

                        case Constants.penny: coinValue = "0"; break;

                        default: coinValue = ""; break;

                    }

                    if (coinValue == "")
                    {
                        Console.WriteLine("Please insert valid coin");
                        break;
                    }
                    else if (coinValue == "0")
                    {
                        coinReturn = coinReturn + coinType;
                        Console.WriteLine("Pennies are not allowed. Please insert valid coin");
                        break;
                    }
                    else
                    {
                        amount = (Convert.ToDecimal(amount) + Convert.ToDecimal(coinValue)).ToString();
                    }

                    if (pd.getProduct(product, amount))
                    {
                        break;
                    }

                }

                Console.ReadLine();
            }
        }
    }
}
