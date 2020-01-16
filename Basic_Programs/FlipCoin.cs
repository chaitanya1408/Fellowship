using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class FlipCoin
    {
        public static void TossInput()
        {
            Console.WriteLine("Enter How many Tosses do you wants|?");
            int toss = Utility.IntegerInput();
            Utility.FlipCoinCalculation(toss);
        }
    }
}
