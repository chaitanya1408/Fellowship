using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class SumOfThreeIntegersAddsToZero
    {
        public static void SumArray()
        {
            try
            {
                Console.WriteLine("Enter how many elements do you want in an array");
                int input = Convert.ToInt32(Console.ReadLine());
                Utility.AddThreeElements(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
