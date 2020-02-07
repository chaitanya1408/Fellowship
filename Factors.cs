using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class Factors
    {
        public static void FactorInput()
        {
            try
            {
                Console.WriteLine("Enter the number of which Do you want to find Factors ");
                int number = Convert.ToInt32(Console.ReadLine());
                Utility.Factorscalculator(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
