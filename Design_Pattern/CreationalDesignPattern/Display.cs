
namespace FellowshipChaitanya.Design_Pattern.CreationalDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Display as a class to check Creational Design Pattern
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Function to execute Creational Design Pattern
        /// </summary>
        public static void DisplayFunction()
        {
            try
            {
                Console.WriteLine("1: Singleton Patteen");
                Console.WriteLine("2: Factory Patteen");
                Console.WriteLine("3: Prototype Patteen");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            SingletonPattern.Utility.GetSingleton();
                            break;

                        case 2:
                            FactoryPattern.FactoryPatternInput.FactoryInput();
                            break;

                        case 3:
                            PrototypePattern.PrototypePatternTest.PrototypeFunction();
                            break;

                        default:
                            Console.WriteLine("Invalid input");
                            Console.WriteLine();
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
