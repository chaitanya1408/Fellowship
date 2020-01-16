using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class DayOfWeek
    {
        public static void DayOfWeekInput()
        {
            try
            {
                Console.WriteLine("Enter the month:\t ex.1 for january");
                int month = Utility.IntegerInput();
                Console.WriteLine("Enter the date:");
                int date = Utility.IntegerInput();
                Console.WriteLine("Enter the year");
                int year = Utility.IntegerInput();
                int day = Utility.DayOfWeekCalculator(month, date, year);

                switch (day)
                {
                    case 0:
                        Console.WriteLine("Sunday");
                        break;
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
