using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class StopWatch
    {
        public static void stopwatchInput()
        {
            Console.WriteLine("Press 1 to start the time:");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 1)
            {
                Utility.startTime();
            }
            else
            {
                Console.WriteLine("You entered Wrong input.");
                StopWatch.stopwatchInput();
            }
            Console.WriteLine("Press 2 to Stop watch");
            input = Convert.ToInt32(Console.ReadLine());
            if(input==2)
            {
                Utility.stopTime();
            }
       

        }
        
    }
}
