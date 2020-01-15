using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class GuessNumber
    {
        public static void guessnumberInput()
        {
            Console.WriteLine("Enter Lower boundary of number");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upperer boundary of number");
            int upper = Convert.ToInt32(Console.ReadLine());
            Utility.guessNumberWorking(lower, upper);
        }
    }
}
