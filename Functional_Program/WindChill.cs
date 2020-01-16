using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class WindChill
    {
        public static void Windchill()
        {
            try
            {
                Console.WriteLine("Enter Temperature in fahernheit(Don't enter more than 50 fahernheit))");
                float temperature = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter wind speed in mph(Don't enter more than 120 mph and not less than 3 mph");
                float speed = Convert.ToInt32(Console.ReadLine());
                Utility.Effectivewindchill(temperature, speed);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
