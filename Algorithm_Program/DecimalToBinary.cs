using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class DecimalToBinary
    {
        public static void decimalInput()
        {
            Console.WriteLine("Enter decimal number");
            int number = Utility.IntegerInput();
            Console.WriteLine("Binary Conversion of " + number);
            int[] result=Utility.decimalToBinaryconverter(number);
            Console.WriteLine();
            int newnumber=Utility.swapNibbles(number);
            Console.WriteLine("after swapping nibbles New Number is:" + newnumber);
            Utility.decimalToBinaryconverter(newnumber);

        }
    }
}
