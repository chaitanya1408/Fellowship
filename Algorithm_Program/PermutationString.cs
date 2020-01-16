using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public  class PermutationString
    {
        public static void PermutationStringInput()
        {
            int count = 0;
            Console.WriteLine("Enter the String to Generate the permutaion string");
            String string1 = Utility.StringInput();
            int length = string1.Length;
            Utility.Permute(string1, 0, length - 1);
            Console.WriteLine(count);
        }
    }
}
