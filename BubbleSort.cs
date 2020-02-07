using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BubbleSort
    {
        public static void BubbleSortInput()
        {
            try
            {
                Console.WriteLine("How many Element do you want to enter");
                int input = Utility.IntegerInput();
                int[] array = Utility.GetInputInArray(input);
                Utility.BubbleSortWork(array);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
