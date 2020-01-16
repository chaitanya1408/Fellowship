using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BubbleSort
    {
        public static void BubbleSortInput()
        {
            Console.WriteLine("How many Element do you want to enter");
            int input = Utility.IntegerInput();
            int[] array = Utility.GetInputInArray(input);
            Utility.BubbleSortWork(array);
        }
    }
}
