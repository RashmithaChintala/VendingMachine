using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Money
    {
        //Check inserted coin
        public String InsertedCoinIs(String coinWeight, String coinSize)
        {
            String coinType = "";

            if(coinWeight != null && coinWeight != "" && coinSize != null && coinSize != "")
            {

                if (coinWeight == Constants.nickelWeight.ToString() && coinSize == Constants.nickelSize.ToString())
                {
                    coinType = Constants.nickel;
                }

                else if (coinWeight == Constants.dimeWeight.ToString() && coinSize == Constants.dimeSize.ToString())
                {
                    coinType = Constants.dime;
                }

                else if (coinWeight == Constants.quarterWeight.ToString() && coinSize == Constants.quarterSize.ToString())
                {
                    coinType = Constants.quarter;
                }

                else if (coinWeight == Constants.pennyWeight.ToString() && coinSize == Constants.pennySize.ToString())
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
