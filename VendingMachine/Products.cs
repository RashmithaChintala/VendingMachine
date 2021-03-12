using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Products
    {
        //dispatching the product
        public bool getProduct(String product, Double amount)
        {
            
            if (product != null && product != "") 
            {
                if(product.ToUpper() == Constants.cola)
                {
                    if(amount == Constants.colaPrice)
                    {
                        Console.WriteLine("Thank you!");
                        return true;
                    }

                    else if (amount < Constants.colaPrice)
                    {
                        Console.WriteLine("Price of the item is " + Constants.colaPrice.ToString() + " Inserted amount is " + amount);
                        Console.WriteLine("Please insert sufficent amount");
                        return false;
                    }
                }

                else if (product.ToUpper() == Constants.chips)
                {
                    if (amount == Constants.chipsPrice)
                    {
                        Console.WriteLine("Thank you!");
                        return true;
                    }

                    else if(amount < Constants.chipsPrice)
                    {
                        Console.WriteLine("Price of the item is " + Constants.chipsPrice.ToString() + " Inserted amount is " + amount);
                        Console.WriteLine("Please insert sufficent amount");
                        return false;
                    }
                }

                else if (product.ToUpper() == Constants.candy)
                {
                    if (amount == Constants.candyPrice)
                    {
                        Console.WriteLine("Thank you!");
                        return true;
                    }

                    else if (amount < Constants.candyPrice)
                    {
                        Console.WriteLine("Price of the item is " + Constants.candyPrice.ToString() + " Inserted amount is " + amount);
                        Console.WriteLine("Please insert sufficent amount");
                        return false;
                    }
                }

                else
                {
                    Console.WriteLine("Product is not available");
                    return false;
                }

            }

            return true;
        }

    }
}
