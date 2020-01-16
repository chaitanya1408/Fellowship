using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class TwoDArray
    {
        public static void ArrayInput()
        {
            Console.WriteLine("Enter Number of Rows In array");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of Columns:");
            int column = Convert.ToInt32(Console.ReadLine());
            Utility.TwoDArray(row, column);
            
        }
    }
}
