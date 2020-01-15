using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeAnagramPalindrome
    {
       public static void primeAnagramPalindrome()
        {
            Console.WriteLine("Enter the lower boundery");
            int lower = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Upper boundary");
            int upper = Convert.ToInt32(Console.ReadLine());
            Utility.primeNumberArray(lower,upper);
        }
    }
}
