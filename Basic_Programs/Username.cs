using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Username
    {
        public static void username()
        {
            Console.WriteLine("Enter Username:");
            String input = Console.ReadLine();
            Utility.username(input);
            
            
        }
    }
}
