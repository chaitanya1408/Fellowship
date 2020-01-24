﻿//----------------------------------------------------
// <copyright file="Calender.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------
namespace FellowshipChaitanya
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Calendar as a class
    /// </summary>
    public class Calender
    {
        /// <summary>
        /// Function for Calendar
        /// </summary>
        public static void CalenderFunction()
        {
            try
            {
                UtilityFunctions utility = new UtilityFunctions();
                Console.WriteLine("Enter month");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter year");
                int date = 1;
                int year = Convert.ToInt32(Console.ReadLine());
                int start = utility.  DayOfweek(date, month, year);
                string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
                string[] days = { "S", "M", "T", "W", "T", "F", "S" };
                Console.WriteLine("Calender " + month + " " + year);
                Console.WriteLine(months[month - 1] + "  " + year);
                int endDate = utility.EndDate(month, year);
                for (int i = 0; i < days.Length; i++)
                {
                    Console.Write(days[i] + "  ");
                }

                Console.WriteLine();                
                int j = 1;
                for (int i = 1; i < endDate + start; i++)
                {
                    if (i < start)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        if (j < 9)
                        {
                            Console.Write(j + "  ");
                        }
                        else
                        {
                            Console.Write(j + " ");
                        }

                        j++;
                    }

                    if (i % 7 == 0)
                    {
                        Console.WriteLine();
                    }
                }               

                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
