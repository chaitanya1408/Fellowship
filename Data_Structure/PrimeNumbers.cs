using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeNumbers
    {
        public static void PrimeNumberInput()
        {
            Console.WriteLine("Enter the lower number of range");
            int lower = Utility.IntegerInput();
            Console.WriteLine("Enter the upper number of the range");
            int upper = Utility.IntegerInput();
            int[] primenumbersarray = Utility.PrimeNumberRange(lower, upper);
            Utility.DisplayPrimeArray(primenumbersarray);

        }
    }
}
