using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeAnagramPalindrome
    {
       public static void PrimeAnagramPalindromeInput()
        {
            try
            {
                Console.WriteLine("Enter the lower boundery");
                int lower = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Upper boundary");
                int upper = Convert.ToInt32(Console.ReadLine());
                Utility.PrimeNumberArray(lower, upper);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
