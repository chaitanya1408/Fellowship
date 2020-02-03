//----------------------------------------------------
// <copyright file="Display.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace FellowshipChaitanya.DesignPatterns.StructuralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Display class for Structural Design Pattern
    /// </summary>
    public class Display
    {
        /// <summary>
        /// Function to execute all Structural Design Patterns
        /// </summary>
        public static void DisplayFunction()
        {
            try
            {
                Console.WriteLine("1: Adapter Pattern");
                Console.WriteLine("2: Facade Pattern");
                Console.WriteLine("3: Proxy Pattern");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {

                        case 1:
                            AdapterPattern.AdapterPatternTest adapterPatternTest = new AdapterPattern.AdapterPatternTest();
                            adapterPatternTest.AdapterPatternFunction();
                            break;

                        case 2:
                            FacadePattern.FacadePatternTest facadePattern = new FacadePattern.FacadePatternTest();
                            facadePattern.FacadeTest();
                            break;

                        case 3:
                            ProxyPattern.ProxyTest proxyTest = new ProxyPattern.ProxyTest();
                            proxyTest.ProxyTestFunction();
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
