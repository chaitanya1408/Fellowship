using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class WindChill
    {
        public static void windchill()
        {
            Console.WriteLine("Enter Temperature in fahernheit(Don't enter more than 50 fahernheit))");
            float temperature = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter wind speed in mph(Don't enter more than 120 mph and not less than 3 mph");
            float speed = Convert.ToInt32(Console.ReadLine());
            Utility.effectivewindchill(temperature, speed);

        }
    }
}
