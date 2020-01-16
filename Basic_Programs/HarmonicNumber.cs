using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class HarmonicNumber
    {
        public static void HarmonicNumberInput()
        {
            try
            {
                Console.WriteLine("Enter the Harmonic Value:\t(Ensure the Number>0)");
                int number = Utility.IntegerInput();
                Utility.HarmonicNumberCalculation(number);
            }
           
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
        }
    }
}
