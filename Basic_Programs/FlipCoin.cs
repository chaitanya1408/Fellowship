using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class FlipCoin
    {
        public static void tossInput()
        {
            Console.WriteLine("Enter How many Tosses do you wants|?");
            int toss = Utility.IntegerInput();
            Utility.flipCoinCalculation(toss);
        }
    }
}
