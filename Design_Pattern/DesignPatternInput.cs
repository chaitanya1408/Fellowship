using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya.Design_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;
    class Design_PatternInput
    {
        public static void DesignPatternInputFunction()
        {
            try
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine();
                    Console.WriteLine("1: Creational Design Pattern");
                    Console.WriteLine("2: Behavioral Design Pattern");
                    Console.WriteLine("3: Structural Design Pattern");
                    Console.WriteLine("4: Annoatation");
                    Console.WriteLine("5: Reflection");
                    Console.WriteLine("6: Exit");
                    string input = Console.ReadLine();
                    if (Regex.IsMatch(input, @"^[0-9]+$"))
                    {
                        int num = Convert.ToInt32(input);
                        switch (num)
                        {
                            case 1:
                                CreationalDesignPattern.Display.DisplayFunction();
                                break;

                            case 2:
                                BehavioralDesignPattern.Display.DisplayFunction();
                                break;

                            case 3:
                                StructuralDesignPattern.Display.DisplayFunction();
                                break;

                            case 4:
                                Annotation.AnnoatationTest.AnnoatationFunction();
                                break;

                            case 5:
                                Reflection.ReflectionTest();
                                break;

                            case 6:
                                exit = true;
                                break;

                            default:
                                Console.WriteLine("Invalid input");
                                Console.WriteLine();
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter valid input to run any program");
                        Console.WriteLine();
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
