using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class DataStructureProgram
    {
        public static void DataStructureProgramList()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine("1. Prime Number ");
                Console.WriteLine("Data structure Program List:");
                Console.WriteLine("Enter Your Choice:");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            PrimeNumberCheck.PrimeNumberCheckeInput();
                            break;
                        default:
                            Console.WriteLine("Wrong Choice.\nDo you want to work in Bassic Program List?\nIf yes press 1 ");
                            choice = Convert.ToInt32(Console.ReadLine());
                            if (choice == 1)
                                BasicPrograms.BasicProgramList();
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
