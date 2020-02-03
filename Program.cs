

namespace FellowshipChaitanya
{
    using System;
    using Object_Oriented_Programs;
    using DesignPatterns;
    using System.Text.RegularExpressions;
    public class Program
    {
        public static void Main()
        { 
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Program List:");
                Console.WriteLine("\n1. Basic Programs\n2. Logical Programs");
                Console.WriteLine("3. Functional Program\n4. Algorithmic Programs");
                Console.WriteLine("5. Collection\n6. Data Structure");
                Console.WriteLine("7. Object Oriented Programming");
                Console.WriteLine("8. Design Pattern");
                Console.WriteLine("9. Exit ");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your Choice:");
                Console.WriteLine("");
                try
                {
                    string input = Console.ReadLine();
                    if (Regex.IsMatch(input, @"^[0-9]+$"))
                    {
                        int choice = Convert.ToInt32(input);
                        switch (choice)
                        {
                            case 1:
                                BasicPrograms.BasicProgramList();
                                break;
                            case 2:
                                LogicalPrograms.LogicalProgramList();
                                break;
                            case 3:
                                FunctionalPrograms.FunctionalProgramList();
                                break;
                            case 4:
                                AlgorithmPrograms.AlgorithmProgramList();
                                break;
                            case 5:
                                List.ListExample1();
                                break;
                            case 6:
                                Data_Structure_Programs.Data_Structure_Program_List();
                                break;
                            case 7:
                                ObjectOrientedPrograms.ObjectOrientedProgramList();
                                break;
                            case 8:
                                Design_PatternInput.DesignPatternInputFunction();
                                break;
                            case 9:
                                Console.WriteLine("Program Exit!!");
                                flag = false;
                                break;
                            default:
                                Console.WriteLine("Wrong Choice.\nDo you want to work in  Program List?\nIf yes press 1 ");
                                if (choice != 0)
                                {
                                    Console.WriteLine("Program Exit!!");
                                    flag = false;
                                }
                                break;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            Console.ReadKey();
           
        }
    } 
}
