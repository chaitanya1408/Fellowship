using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BinarySearchInteger
    {
        public static void BinarySearchInputInteger()
        {
            try
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
                Array.Sort(array);
                Console.WriteLine("Which Number do you want to search");
                int key = Convert.ToInt32(Console.ReadLine());
                Utility.BinarySearchinteger(array, key);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

    }
}
