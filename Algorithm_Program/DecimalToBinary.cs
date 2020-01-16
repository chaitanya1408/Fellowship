using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class DecimalToBinary
    {
        public static void DecimalInput()
        {
            try
            {
                Console.WriteLine("Enter decimal number");
                int number = Utility.IntegerInput();
                Console.WriteLine("Binary Conversion of " + number);
                Utility.DecimalToBinaryconverter(number);
                Console.WriteLine();
                int newnumber = Utility.SwapNibbles(number);
                Console.WriteLine("after swapping nibbles New Number is:" + newnumber);
                Utility.DecimalToBinaryconverter(newnumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
