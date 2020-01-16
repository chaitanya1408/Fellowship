using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class LeapYear
    {
        public static void LeapyaerInput()
        {
            Console.WriteLine("Eneter Four digit year");
            int year = Convert.ToInt32(Console.ReadLine());
            Utility.LeapYearCheck(year);
        }
    }
}
