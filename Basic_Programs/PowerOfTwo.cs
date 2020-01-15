using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class PowerOfTwo
    {
        public static void powerInput()
        {
            Console.WriteLine("Enter the power value.(Enter 0<= Power Value <31)");
            int power = Convert.ToInt32(Console.ReadLine());
            Utility.powerOfTwoCalculation(power);
        }
    }
}
