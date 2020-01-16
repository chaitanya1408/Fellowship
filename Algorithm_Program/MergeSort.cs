using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class MergeSort
    {
        public static void MergeSortInput()
        {
            try
            {
                Console.WriteLine("How many Element do you want to enter");
                int input = Utility.IntegerInput();
                int[] array = Utility.GetInputInArray(input);
                Utility.Sort(array, 0, array.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
