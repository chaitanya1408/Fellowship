using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Gambler
    {
        public static void Gamblerinput()
        {
            Console.WriteLine("Enter the stake:");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Goal:");
            int goal = Convert.ToInt32(Console.ReadLine());

            Utility.Gamblingcalculator(stake, goal);
                
            
              
        }
    }
}
