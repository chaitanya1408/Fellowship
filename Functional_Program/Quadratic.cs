using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Quadratic
    {
        public static void QuadraticEquation()
        {
            Console.WriteLine("Quadratic Equation of a type:a*x*x+b*x+c");
            Console.WriteLine("Enter value for a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value for c:");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quadratic Equation is:(" + a + "*x*x+" + b + "x+" + "c)");
            Utility.QuadraticRoots(a, b, c);

        }

    }
}
