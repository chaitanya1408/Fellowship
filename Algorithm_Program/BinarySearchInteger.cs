using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BinarySearchInteger
    {
        public static void binarySearchInputInteger()
        {
            int i;
            Console.WriteLine("How many numbers do you want to print in the array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            Console.WriteLine("Enter numbers");
            for (i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Which Number do you want to search");
            int key = Convert.ToInt32(Console.ReadLine());
            Utility.binarySearchinteger(array,key);

        }

    }
}
