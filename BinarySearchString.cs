using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BinarySearchString
    {
        public static void BinarySearchInputString()
        {
            try
            {
                int i;
                Console.WriteLine("How many Strings do you want to print in the array");
                int size = Convert.ToInt32(Console.ReadLine());
                String[] array = new String[size];
                Console.WriteLine("Enter Strings:");
                for (i = 0; i < size; i++)
                {
                    array[i] = Console.ReadLine();
                }
                Array.Sort(array);
                Console.WriteLine("Which string do you want to search");
                String key = Console.ReadLine();
                int result = Utility.BinarySearchString(array, key);
                if (result == -1)
                    Console.WriteLine("Element not present");
                else
                    Console.WriteLine("Element found at index " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
