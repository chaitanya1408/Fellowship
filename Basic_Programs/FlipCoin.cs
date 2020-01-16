using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class FlipCoin
    {
        public static void TossInput()
        {
            try
            {
                Console.WriteLine("Enter How many Tosses do you wants|?");
                int toss = Utility.IntegerInput();
                Utility.FlipCoinCalculation(toss);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
