using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class MergeSort
    {
        public static void mergeSortInput()
        {
            Console.WriteLine("How many Element do you want to enter");
            int input = Utility.IntegerInput();
            int[] array = Utility.getInputInArray(input);
            Utility.sort(array,0,array.Length);
        }
    }
}
