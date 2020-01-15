using System;

namespace FellowshipChaitanya
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Program List:");
                Console.WriteLine("\n1. Basic Programs\n2. Logical Programs");
                Console.WriteLine("3. Functional Program\n4. Algorithmic Programs");
                Console.WriteLine("5. Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BasicPrograms.basicProgramList();
                        break;
                    case 2:
                        LogicalPrograms.logicalProgramList();
                        break;
                    case 3:
                        FunctionalPrograms.functionalProgramList();
                        break;
                    case 4:
                        AlgorithmPrograms.AlgorithmProgramList();
                        break;
                    case 5:
                        Console.WriteLine("Program Exit!!");
                        flag = false;                       
                        break;
                    default:
                        Console.WriteLine("Wrong Choice.\nDo you want to work in  Program List?\nIf yes press 1 ");
                        if(choice!=0)
                        {
                            Console.WriteLine("Program Exit!!");
                            flag = false;
                        }
                        break;
                }
            }
               Console.ReadKey();
            
        }
    } 
}
