using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    public class LogicalPrograms
    {
        public static void logicalProgramList()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Logical Program List:");
                Console.WriteLine("\n1. Gambler\n2. Coupon Number ");
                Console.WriteLine("3. stopWatch\n4. Tic Tac Toe");
                Console.WriteLine(" ");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Gambler.gamblerinput();
                        break;

                    case 3:
                        StopWatch.stopwatchInput();
                        break;
                    case 5:
                        Console.WriteLine("Logical Program exit!");
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Choice.\nDo you want to work in Logical Program List?\nIf yes press 1 ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                            LogicalPrograms.logicalProgramList();
                        else
                            flag = false;
                        break;


                }
            }
        }
    }
}
