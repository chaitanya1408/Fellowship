using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class Anagram
    {
        public static void anagramInput()
        {
            Console.WriteLine("Enetr First String");
            String string1=Utility.StringInput();
            Console.WriteLine("Enetr second String");
            String string2 = Utility.StringInput();
            Boolean result=Utility.anagramCheck(string1, string2);
            if (result == true)
                Console.WriteLine(string1 + " and " + string2 + " Strings Anagram");
            else
                Console.WriteLine(string1 + " and " + string2 + " strings are not Anagram");
        }
    }
}
