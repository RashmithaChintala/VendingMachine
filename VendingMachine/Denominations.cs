using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Denominations
    {
        //Check inserted coin
        public String InsertedCoinIs(int coinWeight, int coinSize)
        {
            String coinType = "";

            if(coinWeight > 0 && coinSize > 0)
            {

                if (coinWeight == Constants.nickelWeight && coinSize == Constants.nickelSize)
                {
                    coinType = Constants.nickel;
                }

                else if (coinWeight == Constants.dimeWeight && coinSize == Constants.dimeSize)
                {
                    coinType = Constants.dime;
                }

                else if (coinWeight == Constants.quarterWeight && coinSize == Constants.quarterSize)
                {
                    coinType = Constants.quarter;
                }

                else if (coinWeight == Constants.pennyWeight && coinSize == Constants.pennySize)
                {
                    coinType = Constants.penny;
                }

                else
                    coinType = "";


            }


            return coinType;

        }
    }
}
