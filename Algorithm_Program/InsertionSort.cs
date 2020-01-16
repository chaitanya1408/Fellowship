using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class InsertionSort
    {
        public static void InsertionSortInput()
        {
            Console.WriteLine("How many Element do you want to enter");
            int input = Utility.IntegerInput();
            int [] array=Utility.GetInputInArray(input);
            Utility.InsertionSortWork(array);
        }
    }
}
