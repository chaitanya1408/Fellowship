using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class SquareRoot
    {
        public static void SquarerootInput()
        {
            try
            {
                Console.WriteLine("Enter the number");
                Double number = Utility.DoubleInput();
                Utility.NewtonsMethod(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
