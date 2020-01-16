using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class PrimeNumber
    {
        public static void PrimeNumberInput()
        {
            try 
            {
                Boolean flag = true;
                while (flag)
                {
                    Console.WriteLine("");
                    Console.WriteLine("1. single prime number\n2. Range of Prime Number");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter a number");
                            int number = Convert.ToInt32(Console.ReadLine());
                            Utility.PrimeNumberCalculator(number);
                            break;
                        case 2:
                            Console.WriteLine("Enetr lower boundary of range");
                            int lower = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter upper boundary of range");
                            int upper = Convert.ToInt32(Console.ReadLine());
                            Utility.PrimeNumberRange(lower, upper);
                            break;
                        default:
                            flag = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
