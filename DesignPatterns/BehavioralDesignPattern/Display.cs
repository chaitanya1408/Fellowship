﻿//----------------------------------------------------
// <copyright file="Display.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace FellowshipChaitanya.DesignPatterns.BehavioralDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Display class to check various Behavioral patterns
    /// </summary>
    public class Display
    {
        /// <summary>
        /// DisplayFunction as a function
        /// </summary>
        public static void DisplayFunction()
        {
            try
            {
                Console.WriteLine("1: Observer Patteen");
                Console.WriteLine("2: Visitor Patteen");
                Console.WriteLine("3: Mediator Patteen");
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, @"^[0-9]+$"))
                {
                    int num = Convert.ToInt32(input);
                    switch (num)
                    {
                        case 1:
                            ObserverPattern.ObserverTest observerTest = new ObserverPattern.ObserverTest();
                            observerTest.ObserverFunction();
                            break;

                        case 2:
                            VisitorPattern.ShoppingCartImplement shoppingCart = new VisitorPattern.ShoppingCartImplement();
                            shoppingCart.ShoppingCartDisplay();
                            break;

                        case 3:
                            MediatorPattern.MediatorPattern mediatorPattern = new MediatorPattern.MediatorPattern();
                            mediatorPattern.MediatorFunction();
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
