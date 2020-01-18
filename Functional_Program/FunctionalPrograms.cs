using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class FunctionalPrograms
    {
        public static void FunctionalProgramList()
        {
           
                Boolean flag = true;
                while (flag)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Functional Program List:");
                    Console.WriteLine("\n1. 2D array \n2. Sum Of three Integers adds to zero");
                    Console.WriteLine("3. Distance \n4. Quadratic");
                    Console.WriteLine("5. Windchill");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter Your Choice:");
                    try
                    {
                        int choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:

                                TwoDArray.ArrayInput();
                                break;

                            case 2:

                                SumOfThreeIntegersAddsToZero.SumArray();
                                break;

                            case 3:

                                Distance.DistanceInput();
                                break;

                            case 4:

                                Quadratic.QuadraticEquation();
                                break;

                            case 5:

                                WindChill.Windchill();
                                break;

                            case 6:
                                Console.WriteLine("Exit!");
                                flag = false;
                                break;

                            default:
                                Console.WriteLine("Wrong Choice.\nDo you want to work in Functional Program List?\nIf yes press 1 ");
                                choice = Convert.ToInt32(Console.ReadLine());
                                if (choice == 1)
                                    FunctionalPrograms.FunctionalProgramList();
                                else
                                    flag = false;
                                break;

                        }
                
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }  
        }
    }
}
