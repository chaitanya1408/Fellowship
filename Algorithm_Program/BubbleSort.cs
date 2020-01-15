using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BubbleSort
    {
        public static void bubbleSortInput()
        {
            Console.WriteLine("How many Element do you want to enter");
            int input = Utility.IntegerInput();
            int[] array = Utility.getInputInArray(input);
            Utility.bubbleSortWork(array);
        }
    }
}
