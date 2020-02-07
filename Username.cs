using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class Username
    {
        public static void UsernameInput()
        {
            try
            {
                Console.WriteLine("Enter Username:");
                String input = Console.ReadLine();
                Utility.UsernameWorking(input);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
