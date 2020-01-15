using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class SquareRoot
    {
        public static void squarerootInput()
        {
            Console.WriteLine("Enter the number");
            Double number = Utility.DoubleInput();
            Utility.newtonsMethod(number);
        }
    }
}
