using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class SumOfThreeIntegersAddsToZero
    {
        public static void SumArray()
        {
            Console.WriteLine("Enter how many elements do you want in an array");
            int input = Convert.ToInt32(Console.ReadLine());
            Utility.addThreeElements(input);
        }
    }
}
