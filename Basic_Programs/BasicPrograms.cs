using System;
using System.Collections.Generic;
using System.Text;

namespace FellowshipChaitanya
{
    class BasicPrograms
    {
        public static void basicProgramList()
        {
            Boolean flag = true;
            while (flag)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Basic Program List:");
                Console.WriteLine("\n1. Addition of Two Numbers\n2. Username  ");
                Console.WriteLine("3. Flip Coin  \n4. Leap Year");
                Console.WriteLine("5. Power of Two\n6. Harmonic Number");
                Console.WriteLine("7. Factors");
                Console.WriteLine("8. Exit");
                Console.WriteLine(" ");
                Console.WriteLine("Enter Your Choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AdditionOfTwoNumbers.Addition();
                        break;
                    case 2:
                        Username.username();
                        break;
                    case 3:
                        FlipCoin.tossInput();
                        break;
                    case 4:
                        LeapYear.leapyaer();
                        break;
                    case 5:
                        PowerOfTwo.powerInput();
                        break;
                    case 6:
                        HarmonicNumber.HarmonicNumberInput();
                        break;
                    case 7:
                        Factors.factorInput();
                        break;
                    case 8:
                        Console.WriteLine("Basic Program Exit!!");
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Wrong Choice.\nDo you want to work in Bassic Program List?\nIf yes press 1 ");
                        choice = Convert.ToInt32(Console.ReadLine());
                        if (choice == 1)
                            BasicPrograms.basicProgramList();
                        else
                            flag = false;
                        break;
                }
            }
           

        }
    }
}
