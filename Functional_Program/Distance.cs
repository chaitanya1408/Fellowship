using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Distance
    {
        public static void DistanceInput()
        {
            Console.WriteLine("Enter the value of x axis position:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of y axis position:");
            int y = Convert.ToInt32(Console.ReadLine());
            Utility.EucleadeanDistance(x, y);
        }

    }
}
