using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class AdditionOfTwoNumbers
    {
        public static void Addition()
        {
            int a, b;
            Console.WriteLine("Enter First number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            b = Convert.ToInt32(Console.ReadLine());
            Utility.add(a,b);
            
        }
    }
}
