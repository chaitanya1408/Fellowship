using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Username
    {
        public static void UsernameInput()
        {
            Console.WriteLine("Enter Username:");
            String input = Console.ReadLine();
            Utility.UsernameWorking(input);
            
            
        }
    }
}
