using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class InsertionSort
    {
        public static void insertionSortInput()
        {
            Console.WriteLine("How many Element do you want to enter");
            int input = Utility.IntegerInput();
            int [] array=Utility.getInputInArray(input);
            Utility.insertionSortWork(array);
        }
    }
}
